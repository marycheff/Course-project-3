using Library.DB;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library.Book.UserControls
{
    public partial class BookControl : UserControl
    {
        BookInfo bookInfo;
        public BookControl(BookInfo book)
        {
            InitializeComponent();
            bookInfo = book;

            textTitle.Text = bookInfo.Title;
            textAuthor.Text = DbBook.GetAuthorById(bookInfo.AuthorId);


            string rootDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            string imagePath = rootDirectory + Path.Combine(rootDirectory, bookInfo.CoverImagePath);

            // Проверяем, существует ли файл
            if (File.Exists(imagePath))
            {
                // Загружаем изображение из файла
                panel1.BackgroundImage = Image.FromFile(imagePath);
            }

        }

    }
}
