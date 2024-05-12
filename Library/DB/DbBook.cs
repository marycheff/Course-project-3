using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library.DB
{
    internal class DbBook
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;Username=root;password=root;database=library;";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySqlConnection" + ex.Message, "Error", MessageBoxButtons.OK);
            }
            return conn;
        }

        public static List<BookInfo> GetAllBooks()
        {
            List<BookInfo> books = new List<BookInfo>();

            MySqlConnection conn = GetConnection();
            string query = "SELECT * FROM books";
            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BookInfo book = new BookInfo();
                        book.Id = reader.GetInt32("id");
                        book.Title = reader.GetString("title");
                        book.AuthorId = reader.GetInt32("author_id");
                        book.Genre_id = reader.GetInt32("genre_id");
                        book.Description = reader.GetString("description");
                        book.Available = reader.GetBoolean("available");
                        book.CoverImagePath = reader.GetString("cover_image_path");



                        books.Add(book);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при получении списка книг: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return books;
        }

        public static string GetAuthorById(int id)
        {
            string authorName = "";

            MySqlConnection conn = GetConnection();
            try
            {

                string query = "SELECT name FROM authors WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        authorName = reader.GetString("name");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return authorName;
        }

    }
}
