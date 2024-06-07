using System;
using System.Windows.Forms;

namespace Library.User.UserControls
{
    public partial class UserProfile : UserControl
    {

        public string Email { get; private set; }
        public string Login { get; private set; }
        public event EventHandler RefreshRequest;
        public UserProfile(string name, string login, string email)
        {
            InitializeComponent();
            textName.Text = name;
            textLogin.Text = login;
            textEmail.Text = email;

            Email = email;
            Login = login;


            textName.Enabled = false;
            textLogin.Enabled = false;
            textEmail.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            textLogin.Enabled = true;
            textEmail.Enabled = true;
            btnChangePassword.Visible = true;
            btnChange.Visible = false;
            btnSaveChanges.Visible = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            UserClass userInfo = Registration.UserInfo;
            bool updated = false;

            string inputedLogin = textLogin.Text.Trim();
            string inputedEmail = textEmail.Text.Trim();

            if (Validation.ValidStrings(new string[] { inputedLogin, inputedEmail }) && Validation.ValidEmail(inputedEmail))
            {
                if (Email != inputedEmail && Login != inputedLogin)
                {
                    updated = DbUser.EditUserInfo(userInfo.Id, inputedLogin, inputedEmail);
                    Registration.UserInfo.Login = inputedLogin;
                    Registration.UserInfo.Email = inputedEmail;
                }
                else if (Login != inputedLogin)
                {
                    updated = DbUser.EditUserLogin(userInfo.Id, inputedLogin);
                    Registration.UserInfo.Login = inputedLogin;
                }
                else if (Email != textEmail.Text.Trim())
                {
                    updated = DbUser.EditUserEmail(userInfo.Id, inputedEmail);
                    Registration.UserInfo.Email = inputedEmail;
                }
                else
                {
                    MessageBox.Show("Вы ничего не поменяли");
                }
            }

            if (updated)
            {
                RefreshRequest?.Invoke(this, e);
            }

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

            SetNewPassword setNewPassword = new SetNewPassword();
            setNewPassword.SetLogin(Login);
            setNewPassword.ShowDialog();
            RefreshRequest?.Invoke(this, e);

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }
    }
}