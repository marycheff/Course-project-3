using Library.DB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Library.Admin.UserControls
{
    public partial class CheckAuthorsAndGenres : UserControl
    {
        public event EventHandler UpdateRequare;
        public CheckAuthorsAndGenres()
        {
            InitializeComponent();
            LoadAuthorsData();
            LoadGenresData();
            dataGridAuthors.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 12, FontStyle.Bold);
            dataGridGenres.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 12, FontStyle.Bold);


            if (Registration.UserInfo.RoleId == 2)
            {
                DisableAdminButtons();
            }
        }

        private void DisableAdminButtons()
        {
            dataGridAuthors.Columns["authorEdit"].Visible = false;
            dataGridAuthors.Columns["authorDelete"].Visible = false;
            dataGridGenres.Columns["genreEdit"].Visible = false;
            dataGridGenres.Columns["genreDelete"].Visible = false;
            btnAddAuthor.Visible = false;
            btnAddGenre.Visible = false;
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
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить этого автора?\n{dataGridAuthors.Rows[e.RowIndex].Cells["authorName"].Value}", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DbBook.HasBooksByAuthor(authorId))
                    {
                        MessageBox.Show("Автора нельзя удалить, так как есть минимум одна книга с ним", "Удаление автора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (DbBook.DeleteAuthor(authorId))
                        {
                            dataGridAuthors.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Автор удален успешно", "Удаление автора", MessageBoxButtons.OK);
                        }
                    }

                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridAuthors.Columns["authorEdit"].Index)
            {
                int authorId = Convert.ToInt32(dataGridAuthors.Rows[e.RowIndex].Cells["authorId"].Value);
                string authorName = dataGridAuthors.Rows[e.RowIndex].Cells["authorName"].Value.ToString();
                Book.EditAuthor editAuthor = new Book.EditAuthor(authorName);
                editAuthor.ShowDialog();

                if (editAuthor.SaveClicked)
                {
                    string newAuthorName = editAuthor.NewAuthor;
                    if (newAuthorName == authorName)
                    {
                        MessageBox.Show("Вы ничего не поменяли", "Правка автора", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (Validation.ValidAuthorName(newAuthorName))
                    {
                        if (DbBook.EditAuthor(authorId, newAuthorName))
                        {
                            MessageBox.Show("Имя автора успешно изменено", "Правка автора", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridAuthors.Rows[e.RowIndex].Cells["authorName"].Value = newAuthorName;
                        }
                    }
                }
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
                int genreId = Convert.ToInt32(dataGridGenres.Rows[e.RowIndex].Cells["genreId"].Value);
                string genreName = dataGridGenres.Rows[e.RowIndex].Cells["genreName"].Value.ToString();
                Book.EditGenre editGenre = new Book.EditGenre(genreName);
                editGenre.ShowDialog();
                if (editGenre.SaveClicked)
                {
                    string newGenre = editGenre.NewGenre;
                    if (newGenre == genreName)
                    {
                        MessageBox.Show("Вы ничего не поменяли", "Правка жанра", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (Validation.ValidGenreName(newGenre))
                    {
                        if (DbBook.EditGenre(genreId, newGenre))
                        {
                            MessageBox.Show("Жанр успешно изменен", "Правка жанра", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridGenres.Rows[e.RowIndex].Cells["genreName"].Value = newGenre;

                        }
                    }
                }
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
