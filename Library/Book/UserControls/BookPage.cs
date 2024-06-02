using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Book.UserControls
{
    public partial class BookPage : UserControl
    {
        public BookPage(BookInfo book)
        {
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
    }
}
