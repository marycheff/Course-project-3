using Library.Book;
using Library.DB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library.Admin.UserControls
{
    public partial class CheckBook : UserControl
    {
        public CheckBook()
        {
            InitializeComponent();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 11, FontStyle.Bold);
            LoadBookData();
        }
        private void LoadBookData()
        {
            List<global::Book> allBooks = DbBook.GetAllBooks();
            dataGridView1.Rows.Clear();
            foreach (global::Book book in allBooks)
            {
                string authorName = DbBook.GetAuthorById(book.AuthorId);
                string genreName = DbBook.GetGenreById(book.GenreId);
                string availability = book.Available ? "Да" : "Нет";

                dataGridView1.Rows.Add(book.Id, book.Title, authorName, genreName, book.Description, availability);
            }
            dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что клик был по колонке с ссылками
            if (dataGridView1.Columns[e.ColumnIndex].Name == "coverImage" && e.RowIndex >= 0)
            {
                int bookId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                BookImageForm bookImageForm = new BookImageForm(bookId);
                bookImageForm.ShowDialog();
            }

            //Удаление
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                int bookId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить эту книгу?\n{dataGridView1.Rows[e.RowIndex].Cells["title"].Value}", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool deleted = DbBook.DeleteBook(bookId);
                    if (deleted)
                    {
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Книга удалена успешно", "Удаление книги", MessageBoxButtons.OK);
                    }
                }
            }


            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["edit"].Index)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                EditBookForm editBookForm = new EditBookForm(id);
                editBookForm.ShowDialog();

                if (editBookForm.SaveClicked)
                {
                    
                    string editedTitle = editBookForm.Title;
                    int editedAuthorId = editBookForm.AuthorId;
                    int editedGenreId = editBookForm.GenreId;
                    string editedDescription = editBookForm.Description;
                    bool editedAvailable = editBookForm.Available;

                    bool edited = DbBook.EditBookInfo(id, editedTitle, editedAuthorId, editedGenreId, editedDescription, editedAvailable);
                    if (edited)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells["title"].Value = editedTitle;
                        dataGridView1.Rows[e.RowIndex].Cells["author"].Value = DbBook.GetAuthorById(editedAuthorId);
                        dataGridView1.Rows[e.RowIndex].Cells["genre"].Value = DbBook.GetGenreById(editedGenreId);
                        dataGridView1.Rows[e.RowIndex].Cells["description"].Value = editedDescription;
                        dataGridView1.Rows[e.RowIndex].Cells["available"].Value = editedAvailable ? "Да" : "Нет";
                        
                    }
                }
            }



        }
    }
}
