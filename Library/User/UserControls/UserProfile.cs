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
            UserInfo userInfo = Registration.UserInfo;
            bool updated = false;
            
            if (Email != textEmail.Text.Trim() && Login != textLogin.Text.Trim())
            {
                updated = DbUser.EditUserInfo(userInfo.Id, textLogin.Text.Trim(), textEmail.Text.Trim());
            }
            else if(Login != textLogin.Text.Trim())
            {
                updated = DbUser.EditUserLogin(userInfo.Id, textLogin.Text.Trim());
            }
            else if (Email != textEmail.Text.Trim())
            {
                updated = DbUser.EditUserEmail(userInfo.Id, textEmail.Text.Trim());
            }
            else
            {
                MessageBox.Show("Вы ничего не поменяли");
            }
            
            if (updated)
            {
                RefreshRequest?.Invoke(this, e);
            }

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textLogin.Text);
            SetNewPassword setNewPassword = new SetNewPassword();
            setNewPassword.SetLogin(Login);
            setNewPassword.ShowDialog();
            RefreshRequest?.Invoke(this, e);

        }
    }
}