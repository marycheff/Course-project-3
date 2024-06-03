using Library.DB;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Library.Book.UserControls
{
    public partial class BookPage : UserControl
    {
        BookInfo book;
        UserInfo userInfo = Registration.UserInfo;
        public BookPage(BookInfo book)
        {
            this.book = book;
            InitializeComponent();
            textTitle.Text = book.Title;
            textDescription.Text = book.Description;

            string rootDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            string imagePath = rootDirectory + Path.Combine(rootDirectory, book.CoverImagePath);

            if (File.Exists(imagePath))
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    using (Image image = Image.FromStream(fs))
                    {
                        panel1.BackgroundImage = new Bitmap(image);
                    }
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string reservationCode = GenerateReservationCode();
            if (!DbBook.HasReservedBook(userInfo.Id))
            {
                bool reserved = DbBook.ReserveBook(book.Id, userInfo.Id, reservationCode);
                if (reserved)
                {
                    MessageBox.Show($"Бронирование успешно\n\n\n" +
                        $"Назовите код библиотекарю: {reservationCode.Insert(2, "-")}\n\n" +
                        $"Для подробной информации см. раздел \"Мои книги\"", "Бронирование книги",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("У вас уже есть одна заброннированная книга, бронировать больше одной книги нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GenerateReservationCode()
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
