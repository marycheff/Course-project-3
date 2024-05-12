using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminMainWindow : Form
    {
        public AdminMainWindow()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose();
            }

            AddUser addUser = new AddUser();
            flowLayoutPanel1.Controls.Add(addUser);
            addUser.Focus();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        { 
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                Control currentControl = flowLayoutPanel1.Controls[0];
                flowLayoutPanel1.Controls.Remove(currentControl);
                flowLayoutPanel1.Controls.Clear();
                currentControl.Dispose(); // Освобождаем ресурсы
            }

            CheckUser deleteUser = new CheckUser();
            flowLayoutPanel1.Controls.Add(deleteUser);
            deleteUser.Focus();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
