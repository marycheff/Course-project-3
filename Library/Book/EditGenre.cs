using System;
using System.Windows.Forms;

namespace Library.Book
{
    public partial class EditGenre : Form
    {
        public bool SaveClicked;
        public string NewGenre;
        public EditGenre(string oldGenre)
        {
            InitializeComponent();
            textGenreName.Text = oldGenre;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewGenre = textGenreName.Text.Trim();
            SaveClicked = true;
            Close();
        }
    }
}
