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
                        book.GenreId = reader.GetInt32("genre_id");
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
        public static BookInfo GetBook(int id)
        {
            BookInfo book = null;
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT * FROM books WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        book = new BookInfo();
                        book.Id = reader.GetInt32("id");
                        book.Title = reader.GetString("title");
                        book.AuthorId = reader.GetInt32("author_id");
                        book.GenreId = reader.GetInt32("genre_id");
                        book.Description = reader.GetString("description");
                        book.Available = reader.GetBoolean("available");
                        book.CoverImagePath = reader.GetString("cover_image_path");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении информации о книге: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return book;
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
        public static string GetGenreById(int id)
        {
            string genre = "";

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT name FROM genres WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        genre = reader.GetString("name");
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

            return genre;
        }
        public static string GetTitleById(int id)
        {
            string title = "";

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT title FROM books WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        title = reader.GetString("title");
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

            return title;
        }
        public static string GetImagePathById(int id)
        {
            string imagePath = "";

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT cover_image_path FROM books WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        imagePath = reader.GetString("cover_image_path");
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

            return imagePath;
        }
        public static int GetAuthorId(string author)
        {
            int authorId = -1;
            MySqlConnection conn = GetConnection();
            string query = "SELECT id FROM authors WHERE name = @author";
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@author", author);
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    authorId = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении ID автора: " + ex.Message, "Ошибка");
            }
            finally
            {
                conn.Close();
            }
            return authorId;
        }
        public static int GetGenreId(string genre)
        {
            int genreId = -1;
            MySqlConnection conn = GetConnection();
            string query = "SELECT id FROM genres WHERE name = @genre";
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@genre", genre);
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    genreId = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении ID жанра: " + ex.Message, "Ошибка");
            }
            finally
            {
                conn.Close();
            }
            return genreId;
        }
        public static string[] GetAllAuthors()
        {
            List<string> authors = new List<string>();
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT name FROM authors";
                MySqlCommand command = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string authorName = reader.GetString("name");
                        authors.Add(authorName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении списка авторов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return authors.ToArray();
        }
        public static string[] GetAllGenres()
        {
            List<string> genres = new List<string>();
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT name FROM genres";
                MySqlCommand command = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string genreName = reader.GetString("name");
                        genres.Add(genreName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении списка авторов: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return genres.ToArray();
        }
        public static bool GetAvailabilityId(int id)
        {
            bool available = false;

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT available FROM books WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        available = reader.GetBoolean("available");
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

            return available;
        }
        public static bool DeleteBook(int id)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "DELETE FROM books WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении пользователя: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


        public static bool EditBookInfo(int bookId, string title, int authorId, int genreId, string description, bool available)
        {
            MySqlConnection conn = GetConnection();
           
            try
            {
                string query = "UPDATE books SET title = @title, author_id = @authorId, genre_id = @genreId, description = @description, available = @available WHERE id = @bookId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@bookId", bookId);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@authorId", authorId);
                command.Parameters.AddWithValue("@genreId", genreId);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@available", available);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при правке книги: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }

        }
        public static bool AddBook(string title, int authorId, int genreId, string description, bool available, string coverImagePath)
        {
            MySqlConnection conn = GetConnection();

            try
            {

                string query = @"INSERT INTO books (title, author_id, genre_id, description, available, cover_image_path)
                         VALUES (@title,@author_id, @genre_id, @description, @available, @coverImagePath)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author_id", authorId);
                command.Parameters.AddWithValue("@genre_id", genreId);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@available", available);
                command.Parameters.AddWithValue("@coverImagePath", coverImagePath);

                // Выполняем запрос
                int rowsAffected = command.ExecuteNonQuery();

                // Если добавление прошло успешно, возвращаем true, иначе false
                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при добавлении книги: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
