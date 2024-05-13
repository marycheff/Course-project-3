using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Library
{
    public class Valid
    {
        public static bool ValidName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Split(' ').Length != 3)
            {
                MessageBox.Show("Введите ФИО в формате \"Фамилия Имя Отчество\"","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public static bool ValidEmail(string email)
        {
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
            {
                MessageBox.Show("Email введен некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public static bool ValidPassword(string password)
        {
            //if(password.Length < 5)
            //{
            //    MessageBox.Show("Пароль меньше 5 символов введен некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            return true;
        }
        public static bool ValidPasswords(string password, string passwordRepeat)
        {
            //if (password.Length < 5)
            //{
            //    MessageBox.Show("Пароль меньше 5 символов введен некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            if(password != passwordRepeat)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public static bool ValidStrings(string[] array)
        {
            foreach (string str in array)
            {
                if (string.IsNullOrEmpty(str))
                {
                    MessageBox.Show("Введены не все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public static bool ValidLogin(string login)
        {
            return true;
        }
    }
}
