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
               passwordChanged = DbUser.EditUserPasswordByLogin(Login, md5.hashPassword(textPassword.Text.Trim()), md5.hashPassword(textPasswordRepeat.Text.Trim()));
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
