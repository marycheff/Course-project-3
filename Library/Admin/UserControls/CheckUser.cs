using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public partial class CheckUser : UserControl
    {
        public CheckUser()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            Dictionary<int, Dictionary<string, object>> usersDict = DbUser.GetAllUsers();
            foreach (var userData in usersDict.Values)
            {
                object[] rowData = new object[dataGridView1.ColumnCount];
                rowData[0] = userData["id"];
                rowData[1] = userData["name"];
                rowData[2] = userData["login"];
                rowData[3] = userData["email"];
                rowData[4] = userData["role"];
                dataGridView1.Rows.Add(rowData);
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Удаление
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                int userId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить этого пользователя?\n{dataGridView1.Rows[e.RowIndex].Cells["Username"].Value}", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool deleted = DbUser.DeleteUser(userId);
                    if (deleted)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Пользователь удален успешно", "Удаление пользователя", MessageBoxButtons.OK);
                    }
                }
            }

            //Редактирование
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                string name = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
                string login = dataGridView1.Rows[e.RowIndex].Cells["login"].Value.ToString();
                string email = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                int roleId = DbUser.GetRoleId(dataGridView1.Rows[e.RowIndex].Cells["role"].Value.ToString());

                EditUserForm editForm = new EditUserForm(name, login, email, roleId);
                editForm.ShowDialog();

                if (editForm.SaveClicked)
                {
                    bool edited = DbUser.EditUserInfo(id, editForm.Name, editForm.Login, editForm.Email, editForm.RoleId);
                    if (edited)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["username"].Value = editForm.Name;
                        dataGridView1.Rows[e.RowIndex].Cells["login"].Value = editForm.Login;
                        dataGridView1.Rows[e.RowIndex].Cells["email"].Value = editForm.Email;
                        dataGridView1.Rows[e.RowIndex].Cells["role"].Value = DbUser.GetRoleName(editForm.RoleId);
                        MessageBox.Show("Пользователь успешно изменен", "Редактирование пользователя", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при изменении пользователя", "Редактирование пользователя", MessageBoxButtons.OK);
                    }
                }
            }


        }

    }
}
