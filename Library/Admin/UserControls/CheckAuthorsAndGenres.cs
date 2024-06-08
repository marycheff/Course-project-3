using Library.DB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Admin.UserControls
{
    public partial class CheckAuthorsAndGenres : UserControl
    {
        public CheckAuthorsAndGenres()
        {
            InitializeComponent();
            LoadAuthorsData();
            LoadGenresData();
            dataGridAuthors.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 12, FontStyle.Bold);
            dataGridGenres.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 12, FontStyle.Bold);
        }

        private void LoadAuthorsData()
        {
            List<Classes.Author> authors = DbBook.GetAllAuthors();
            dataGridAuthors.Rows.Clear();
            foreach (Classes.Author author in authors)
            {
                dataGridAuthors.Rows.Add(author.Id, author.Name);
            }
        }
        private void LoadGenresData()
        {
            List<Classes.Genre> genres = DbBook.GetAllGenres();
            dataGridGenres.Rows.Clear();
            foreach (Classes.Genre author in genres)
            {
                dataGridGenres.Rows.Add(author.Id, author.Name);
            }
        }

        private void dataGridAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridAuthors.Columns["authorDelete"].Index)
            {
                int authorId = Convert.ToInt32(dataGridAuthors.Rows[e.RowIndex].Cells["authorId"].Value);
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить этого автора\n{dataGridAuthors.Rows[e.RowIndex].Cells["authorName"].Value}", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    if (DbBook.DeleteAuthor(authorId))
                    {
                        dataGridAuthors.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Автор удален успешно", "Удаление автора", MessageBoxButtons.OK);
                    }
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridAuthors.Columns["authorEdit"].Index)
            {
            }
        }

        private void dataGridGenres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridGenres.Columns["genreDelete"].Index)
            {
                int genreId = Convert.ToInt32(dataGridGenres.Rows[e.RowIndex].Cells["genreId"].Value);
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить этот жанр?\n{dataGridGenres.Rows[e.RowIndex].Cells["genreName"].Value}", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DbBook.DeleteGenre(genreId))
                    {
                        dataGridGenres.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Жанр удален успешно", "Удаление жанра", MessageBoxButtons.OK);
                    }
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridGenres.Columns["genreEdit"].Index)
            {
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.AuthorAdded += AddAuthor_AuthorAdded;
            addAuthor.ShowDialog();

        }

        private void AddAuthor_AuthorAdded(object sender, EventArgs e)
        {
            LoadAuthorsData();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            AddGenre addGenre = new AddGenre();
            addGenre.GenreAdded += AddGenre_GenreAdded;
            addGenre.ShowDialog();
            LoadGenresData();
        }

        private void AddGenre_GenreAdded(object sender, EventArgs e)
        {
            LoadGenresData();
        }
    }
}
