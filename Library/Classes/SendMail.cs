using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

// password:
// giTIrui,AU21


// mail 
// library-test-marychev
namespace Library
{
    internal class SendMail
    {
        public static string ResetPassword(string toAddress)
        {
            string smtpServer = "smtp.mail.ru";
            int smtpPort = 587;
            string fromAddress = "library-test-marychev@mail.ru";
            string fromPassword = "ia8v6PHxt2699XNqqrhW";
            string code = GenerateCode(5);
            using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
            {
                smtpClient.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtpClient.EnableSsl = true;

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(fromAddress);
                    mailMessage.To.Add(toAddress);
                    mailMessage.Subject = "Сброс пароля";
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = "Ваш код подтверждения для сброса пароля: " + code;
                    try
                    {
                        smtpClient.Send(mailMessage);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка отправки письма");
                    }
                }
                return code;
            }

        }

        private static string GenerateCode(int length)
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
