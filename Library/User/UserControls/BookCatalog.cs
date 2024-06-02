using Library.DB;
using Library.Book;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Library.Book.UserControls
{
    public partial class BookCatalog : UserControl
    {
        BookInfo bookInfo;
        FlowLayoutPanel parentPanel;
        public BookCatalog(BookInfo book, FlowLayoutPanel parent)
        {
            InitializeComponent();
            bookInfo = book;
            parentPanel = parent;
            textTitle.Text = bookInfo.Title;
            textAuthor.Text = DbBook.GetAuthorById(bookInfo.AuthorId);
            string rootDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\"));
            string imagePath = rootDirectory + Path.Combine(rootDirectory, bookInfo.CoverImagePath);
            if (File.Exists(imagePath))
            {
                panel1.BackgroundImage = Image.FromFile(imagePath);
            }
            AddMouseEnterLeaveEvents(this);
            AddClickEvents(this);

        }

        private void BookControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(85, 89, 94);
        }
        private void BookControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(62, 65, 69);
        }
        private void AddMouseEnterLeaveEvents(Control control)
        {
            control.MouseEnter += BookControl_MouseEnter;
            control.MouseLeave += BookControl_MouseLeave;

            foreach (Control child in control.Controls)
            {
                AddMouseEnterLeaveEvents(child);
            }
        }
        private void AddClickEvents(Control control)
        {
            control.Click += BookCatalog_Click;

            foreach (Control child in control.Controls)
            {
                AddClickEvents(child);
            }
        }

        private void BookCatalog_Click(object sender, EventArgs e)
        {
            OpenBookPage();
        }
        private void OpenBookPage()
        {
            parentPanel.Controls.Clear();
            BookPage bookPage = new BookPage(bookInfo);
            bookPage.Dock = DockStyle.Top;
            parentPanel.Controls.Add(bookPage);
        }
    }
}
