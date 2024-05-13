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
                dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
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
                    bool edited = false;
                    string editedName = editForm.Name;
                    string editedEmail = editForm.Email;
                    string editedLogin = editForm.Login;
                    int editedRoleId = editForm.RoleId;

                    if (name != editedName && email == editedEmail && login == editedLogin)
                    {
                        edited = DbUser.EditUserName(id, editedName);
                    }
                    else if (email != editedEmail && login != editedLogin)
                    {

                        edited = DbUser.EditUserInfo(id, editedName, editedLogin, editedEmail, editedRoleId);
                    }
                    else if (login != editedLogin)
                    {
                        edited = DbUser.EditUserLogin(id, editedLogin);
                    }
                    else if (email != editedEmail)
                    {
                        edited = DbUser.EditUserEmail(id, editedEmail);
                    }
                    else if (roleId != editForm.RoleId)
                    {
                        edited = DbUser.EditUserRole(id, editedRoleId);  
                    }
                    else
                    {
                        MessageBox.Show("Вы ничего не поменяли");
                    }


                    if (edited)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["username"].Value = editedName;
                        dataGridView1.Rows[e.RowIndex].Cells["login"].Value = editedLogin;
                        dataGridView1.Rows[e.RowIndex].Cells["email"].Value = editedEmail;
                        dataGridView1.Rows[e.RowIndex].Cells["role"].Value = DbUser.GetRoleName(editForm.RoleId);
                    }
                }


            }


        }

    }
}
