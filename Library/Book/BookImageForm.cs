using Library.DB;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library.Book
{
    public partial class BookImageForm : Form
    {
        public BookImageForm(int bookId)
        {
            InitializeComponent();
            Text = DbBook.GetTitleById(bookId);
            string rootDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            string imagePath = rootDirectory + Path.Combine(rootDirectory, DbBook.GetImagePathById(bookId));

            // Проверяем, существует ли файл
            if (File.Exists(imagePath))
            {
                this.BackgroundImage = Image.FromFile(imagePath);
            }

        }
    }
}
