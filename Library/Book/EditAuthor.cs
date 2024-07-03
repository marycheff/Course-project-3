using System;
using System.Windows.Forms;

namespace Library.Book
{
    public partial class EditAuthor : Form
    {
        public bool SaveClicked;
        public string NewAuthor;
        public EditAuthor(string oldAuthor)
        {
            InitializeComponent();
            textAuthorName.Text = oldAuthor;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            NewAuthor = textAuthorName.Text.Trim();
            SaveClicked = true;
            Close();
        }

    }
}
