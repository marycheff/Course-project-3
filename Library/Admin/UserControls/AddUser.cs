using Library.DB;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
            comboRole.SelectedIndex = 0;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string login = textLogin.Text.Trim();
            string email = textEmail.Text.Trim();
            string password = md5.hashPassword(textPassword.Text.Trim());
            int roleId = comboRole.SelectedIndex + 1;

            bool userAdded = DbUser.Register(name, login, email, password, roleId);

            if (userAdded)
            {
                textName.Text = string.Empty;
                textLogin.Text = string.Empty;
                textPassword.Text = string.Empty;
                textEmail.Text = string.Empty;
                comboRole.SelectedIndex = 0;
            }
            else
            {
                textPassword.Text = string.Empty;
            }
        }


    }
}
