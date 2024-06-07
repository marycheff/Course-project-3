using Library.DB;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace Library.Book.UserControls
{
    public partial class BookCatalog : UserControl
    {
        readonly global::Book bookInfo;
        readonly FlowLayoutPanel parentPanel;
        public BookCatalog(global::Book book, FlowLayoutPanel parent)
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
