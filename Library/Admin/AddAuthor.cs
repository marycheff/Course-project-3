using Library.DB;
using System;
using System.Windows.Forms;

namespace Library.Admin
{
    public partial class AddAuthor : Form
    {
        public event EventHandler AuthorAdded;
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string authorName = textAuthorName.Text.Trim();

            if (Validation.ValidAuthorName(authorName))
            {
                if (DbBook.AddAuthor(Validation.Capitalize(authorName)))
                {
                    MessageBox.Show("Автор добавлен");
                    AuthorAdded?.Invoke(this, e);
                    this.Close();
                }
            }
        }
    }
}