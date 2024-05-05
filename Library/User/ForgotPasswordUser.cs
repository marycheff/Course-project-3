using System;
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public partial class ForgotPasswordUser : Form
    {
        public string Email { get; private set; }
        public bool SendClicked { get; private set; }
        public ForgotPasswordUser()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Email = textEmail.Text.Trim();

            bool emailValid = DbUser.CheckEmail(Email);
            if (emailValid)
            {
                string code = SendMail.ResetPassword(Email);
                MessageBox.Show("Код отправлен", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InputCode inputCode = new InputCode(code);
                inputCode.ShowDialog();
                if (inputCode.CodesMatch)
                {
                    Close();
                }
                else
                {
                    btnSend.Text = "Отправить код еще раз";
                    btnSend.Location = new Point(btnSend.Location.X - 21, btnSend.Location.Y);
                }
            }
            else
            {
                MessageBox.Show("Такого email нет в базе данных", "Восстановление пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEmail.Text = string.Empty;
            }
            SendClicked = true;
            // Close();
        }
    }
}
