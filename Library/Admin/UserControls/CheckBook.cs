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
            List<BookInfo> allBooks = DbBook.GetAllBooks();
       
            foreach (BookInfo book in allBooks)
            {
                object[] rowData = new object[dataGridView1.ColumnCount];
                rowData[0] = book.Id;
                rowData[1] = book.Title;
                rowData[2] = DbBook.GetAuthorById(book.AuthorId);
                rowData[3] = DbBook.GetGenreById(book.GenreId);
                rowData[4] = book.Description;
                rowData[5] = book.Available ? "Да" : "Нет";
                dataGridView1.Rows.Add(rowData);
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
