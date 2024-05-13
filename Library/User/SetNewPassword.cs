using Library.DB;
using System.Windows.Forms;

namespace Library.User
{
    public partial class SetNewPassword : Form
    {
        public string Login { get; private set; }
        public string Email { get; private set; }
        public SetNewPassword()
        {
            InitializeComponent();
        }
        public void SetLogin(string login)
        {
            Login = login;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }




        private void btnSave_Click(object sender, System.EventArgs e)
        {
            bool passwordChanged = false;
            if (Login != null && Email == null)
            {
                if (Validation.ValidPasswords(textPassword.Text.Trim(), textPasswordRepeat.Text.Trim())){
                    passwordChanged = DbUser.EditUserPasswordByLogin(Login, textPassword.Text.Trim());

                }
            }
            else if (Email != null && Login == null)
            {

            }
            if (passwordChanged)
            {
                Close();
            }
            else
            {

            }
        }
    }
}
