using System;
using System.Windows.Forms;

namespace Library.User.UserControls
{
    public partial class UserProfile : UserControl
    {
        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Email { get; private set; }
        public event EventHandler RefreshRequest;
        public UserProfile(string name, string login, string email)
        {
            InitializeComponent();
            textName.Text = name;
            textLogin.Text = login;
            textEmail.Text = email;

            textName.Enabled = false;
            textLogin.Enabled = false;
            textEmail.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            textLogin.Enabled = true;
            textEmail.Enabled = true;
            btnChange.Visible = false;
            btnSaveChanges.Visible = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = Registration.UserInfo;
            bool updated = DbUser.EditUserInfo(userInfo.Id, textLogin.Text.Trim(), textEmail.Text.Trim());
            if (updated)
            {
                RefreshRequest?.Invoke(this, e);
            }

        }
    }
}