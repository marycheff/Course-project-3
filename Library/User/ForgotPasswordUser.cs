using Library.User;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class ForgotPasswordUser : Form
    {
        public string Email { get; private set; }
        public string Login { get; private set; }
        public bool SendClicked { get; private set; }
        public ForgotPasswordUser()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Email = textEmail.Text.Trim();
            Login = textLogin.Text.Trim();


            if (Validation.ValidStrings(new string[] { Email, Login }) &&
                Validation.ValidLogin(Login) &&
                Validation.ValidEmail(Email))
            {
                bool emailExists = DbUser.CheckEmail(Email);
                bool loginExists = DbUser.CheckLogin(Login);
                bool emailAssociatedWithLogin = DbUser.EmailAssociatedWithLogin(Email, Login);


                if (emailExists && loginExists && emailAssociatedWithLogin)
                {
                    string code = SendMail.ResetPassword(Email);
                    MessageBox.Show($"Код отправлен на {Email}", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InputCode inputCode = new InputCode(code);
                    inputCode.ShowDialog();
                    if (inputCode.CodesMatch)
                    {
                        SetNewPassword setNewPassword = new SetNewPassword();
                        setNewPassword.SetLogin(Login);
                        setNewPassword.ShowDialog();
                        Close();
                    }
                    else
                    {
                        btnSend.Text = "Отправить код еще раз";
                        btnSend.Location = new Point(btnSend.Location.X - 21, btnSend.Location.Y);
                    }
                }
                else if (!emailExists && loginExists)
                {
                    MessageBox.Show("Такого email нет в базе данных", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textEmail.Text = string.Empty;
                }
                else if (emailExists && !loginExists)
                {
                    MessageBox.Show("Такого логина нет в базе данных", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textLogin.Text = string.Empty;
                }
                else if (emailExists && loginExists && !emailAssociatedWithLogin)
                {
                    MessageBox.Show("Логин и email не относятся к одному и тому же пользователю", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textLogin.Text = string.Empty;
                    textEmail.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Таких email и логина нет в базе данных", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textLogin.Text = string.Empty;
                    textEmail.Text = string.Empty;
                }
                SendClicked = true;
            }
            // Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обратитесь в библиотеку", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
