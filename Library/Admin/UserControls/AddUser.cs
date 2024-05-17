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
            string name = TextSurname.Text.Trim() + " " + TextName.Text.Trim() + " " + TextPatronymic.Text.Trim();
            string login = textLogin.Text.Trim();
            string email = textEmail.Text.Trim();
            string password = textPassword.Text.Trim();
            int roleId = comboRole.SelectedIndex + 1;

            bool userAdded = false;

            if (Validation.ValidStrings(new string[] { name, login, email, password }) &&
                Validation.ValidName(name) &&
                Validation.ValidEmail(email) &&
                Validation.ValidPassword(password) &&
                Validation.ValidName(name))
            {
                userAdded = DbUser.Register(name, login, email, password, roleId);
            }

            if (userAdded)
            {
                TextSurname.Text = string.Empty;
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
