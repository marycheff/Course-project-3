using Library.DB;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class Registration : Form
    {
        internal static UserInfo UserInfo;
        public Registration()
        {
            InitializeComponent();
            tabAuthButton.Click += TabAuthButton_Click;
            tabRegButton.Click += TabRegButton_Click;

        }

        private void TabAuthButton_Click(object sender, EventArgs e)
        {
            string login = tabAuthTextLogin.Text;
            string password = md5.hashPassword(tabAuthTextPassword.Text);
            int loggedIn = DbUser.Login(login, password);
            if (loggedIn == 3)
            {
                UserMainWindow userMainWindow = new UserMainWindow();
                userMainWindow.Closed += (s, args) => this.Close();
                Hide();
                UserInfo = DbUser.GetUserInfoByLogin(login);
                userMainWindow.Show();

            }
            else if (loggedIn == 2 || loggedIn == 1)
            {
                AdminMainWindow adminMainWindow = new AdminMainWindow();
                adminMainWindow.Closed += (s, args) => this.Close();
                Hide();
                adminMainWindow.Show();
            }
            else
            {
                tabAuthTextLogin.Text = string.Empty;
                tabAuthTextPassword.Text = string.Empty;
            }
        }

        private void TabRegButton_Click(object sender, EventArgs e)
        {
            string name = tabRegTextName.Text.Trim();
            string login = tabRegTextLogin.Text.Trim();
            string email = tabRegTextEmail.Text.Trim();
            string password = md5.hashPassword(tabRegTextPassword.Text.Trim());
            string passwordRepeat = md5.hashPassword(tabRegTextPasswordRepeat.Text.Trim());
            bool registered = DbUser.Register(name, login, email, password, passwordRepeat);
            if (registered)
            {
                UserMainWindow userMainWindow = new UserMainWindow();
                userMainWindow.Closed += (s, args) => Close();
                Hide();
                userMainWindow.Show();
            }
            else
            {
                tabRegTextPassword.Text = string.Empty;
                tabRegTextPasswordRepeat.Text = string.Empty;
            }
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            ForgotPasswordUser forgotPasswordUser = new ForgotPasswordUser();
            forgotPasswordUser.ShowDialog();

        }
    }
}
