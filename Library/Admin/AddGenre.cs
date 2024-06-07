using Library.DB;
using System;
using System.Windows.Forms;

namespace Library.Admin
{
    public partial class AddGenre : Form
    {
        public event EventHandler GenreAdded;
        public AddGenre()
        {
            InitializeComponent();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string genreName = textGenreName.Text.Trim();

            if (Validation.ValidGenreName(genreName))
            {
                if (DbBook.AddGenre(Validation.Capitalize(genreName)))
                {
                    MessageBox.Show("Жанр добавлен", "Добавление жанра", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenreAdded?.Invoke(this, e);
                    this.Close();
                }
               
            }
        }
    }
}
