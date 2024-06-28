using Library.Classes;
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
            string sql = "datasource=localhost;port=3306;Username=root;password=;database=library;";
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

        //BOOK
        //get
        public static List<global::Book> GetAllBooks()
        {
            List<global::Book> books = new List<global::Book>();
            MySqlConnection conn = GetConnection();
            string query = "SELECT * FROM books";
            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        global::Book book = new global::Book
                        {
                            Id = reader.GetInt32("id"),
                            Title = reader.GetString("title"),
                            AuthorId = reader.GetInt32("author_id"),
                            GenreId = reader.GetInt32("genre_id"),
                            Description = reader.GetString("description"),
                            Available = reader.GetBoolean("available"),
                            CoverImagePath = reader.GetString("cover_image_path")
                        };
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
        public static global::Book GetBook(int id)
        {
            global::Book book = null;
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
                        book = new global::Book
                        {
                            Id = reader.GetInt32("id"),
                            Title = reader.GetString("title"),
                            AuthorId = reader.GetInt32("author_id"),
                            GenreId = reader.GetInt32("genre_id"),
                            Description = reader.GetString("description"),
                            Available = reader.GetBoolean("available"),
                            CoverImagePath = reader.GetString("cover_image_path")
                        };
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
        public static string GetBookTitleById(int bookId)
        {
            string bookTitle = string.Empty;

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT title FROM books WHERE id = @bookId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@bookId", bookId);

                try
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        bookTitle = result.ToString();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении названия книги: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return bookTitle;
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

        public static List<Author> GetAllAuthors()
        {
            List<Author> authors = new List<Author>();
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT id, name FROM authors";
                MySqlCommand command = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Author author = new Author
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name")
                        };
                        authors.Add(author);
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

            return authors;
        }

        public static List<Genre> GetAllGenres()
        {
            List<Genre> genres = new List<Genre>();
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    string query = "SELECT id, name FROM genres";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Genre genre = new Genre
                            {
                                Id = reader.GetInt32("id"),
                                Name = reader.GetString("name")
                            };
                            genres.Add(genre);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при получении списка жанров: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return genres;
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
        public static int GetBookIdByUserId(int userId)
        {
            int bookId = -1;
            MySqlConnection conn = GetConnection();

            string query = "SELECT book_id FROM reservations WHERE user_id = @userId AND rented = 0";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Parameters.AddWithValue("@userId", userId);

            try
            {
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    bookId = Convert.ToInt32(result);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при получении ID книги: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return bookId;
        }
        //other
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
        public static bool AddBook(string title, int authorId, int genreId, string description, bool available)
        {
            MySqlConnection conn = GetConnection();

            try
            {

                string query = @"INSERT INTO books (title, author_id, genre_id, description, available)
                         VALUES (@title,@author_id, @genre_id, @description, @available)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@author_id", authorId);
                command.Parameters.AddWithValue("@genre_id", genreId);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@available", available);

                int rowsAffected = command.ExecuteNonQuery();
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
        public static bool GiveBook(Reservation reservation)
        {
            bool success = false;

            using (MySqlConnection conn = GetConnection())
            {
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    string updateQuery = "UPDATE reservations SET rented = 1 WHERE id = @reservationId";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, conn, transaction);
                    updateCommand.Parameters.AddWithValue("@reservationId", reservation.Id);
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected == 1)
                    {
                        string insertQuery = "INSERT INTO rentals (user_id, book_id, rental_date, reservation_id) VALUES (@userId, @bookId, @rentalDate, @reservationId)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn, transaction);
                        insertCommand.Parameters.AddWithValue("@userId", reservation.UserId);
                        insertCommand.Parameters.AddWithValue("@bookId", reservation.BookId);
                        insertCommand.Parameters.AddWithValue("@rentalDate", DateTime.Now);
                        insertCommand.Parameters.AddWithValue("@reservationId", reservation.Id);

                        insertCommand.ExecuteNonQuery();
                        transaction.Commit();
                        success = true;
                    }
                    else
                    {
                        transaction.Rollback();
                    }
                }
                catch (MySqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ошибка при обновлении бронирования: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return success;
        }
        public static bool TakeBook(int rentalId)
        {
            bool success = false;

            using (MySqlConnection conn = GetConnection())
            {
                string query = "UPDATE rentals SET return_date = @currentDate WHERE id = @rentalId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@currentDate", DateTime.Now);
                command.Parameters.AddWithValue("@rentalId", rentalId);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        success = true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при обновлении данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return success;
        }
        public static bool AddAuthor(string authorName)
        {
            bool isAuthorAdded = false;
            using (MySqlConnection conn = GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM authors WHERE name = @name";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, conn);
                checkCommand.Parameters.AddWithValue("@name", authorName);
                int authorCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (authorCount == 0)
                {
                    // Если автор не существует, добавляем его
                    string insertQuery = "INSERT INTO authors (name) VALUES (@name)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                    insertCommand.Parameters.AddWithValue("@name", authorName);

                    try
                    {
                        insertCommand.ExecuteNonQuery();
                        isAuthorAdded = true;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Ошибка при добавлении автора: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Такой автор уже есть в базе", "Ошибка добавления автора", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isAuthorAdded;
        }
        public static bool AddGenre(string genreName)
        {
            bool isGenreAdded = false;
            using (MySqlConnection conn = GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM genres WHERE name = @name";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, conn);
                checkCommand.Parameters.AddWithValue("@name", genreName);
                int genreCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (genreCount == 0)
                {
                    string insertQuery = "INSERT INTO genres (name) VALUES (@name)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, conn);
                    insertCommand.Parameters.AddWithValue("@name", genreName);

                    try
                    {
                        insertCommand.ExecuteNonQuery();
                        isGenreAdded = true;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Ошибка при добавлении жанра: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Такой жанр уже есть в базе", "Ошибка добавления жанра", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isGenreAdded;
        }
        public static bool DeleteGenre(int id)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "DELETE FROM genres WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении жанра: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool DeleteAuthor(int id)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "DELETE FROM authors WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении автора: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool UpdateCoverImagePath(int bookId, string coverImagePath)
        {
            bool isUpdated = false;
            using (MySqlConnection conn = GetConnection())
            {
                string query = "UPDATE books SET cover_image_path = @coverImagePath WHERE id = @bookId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@coverImagePath", coverImagePath);
                command.Parameters.AddWithValue("@bookId", bookId);

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    isUpdated = rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при обновлении пути к обложке: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                { 
                    conn.Close(); 
                }
            }

            return isUpdated;
        }

        public static bool HasBooksByAuthor(int authorId)
        {
            bool hasBooks = false;
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT COUNT(*) FROM books WHERE author_id = @AuthorId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@AuthorId", authorId);

                int bookCount = Convert.ToInt32(command.ExecuteScalar());
                hasBooks = bookCount > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка при проверке наличия книг у автора: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return hasBooks;
        }


        //RESERVATION
        //get
        public static int GetReservationIdByDate(DateTime reservationDate)
        {
            int reservationId = -1;
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT id FROM reservations WHERE reservation_date = @reservationDate LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@reservationDate", reservationDate);

                try
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        reservationId = Convert.ToInt32(result);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении ID бронирования: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return reservationId;
        }
        public static List<Reservation> GetAllReservations()
        {
            List<Reservation> reservations = new List<Reservation>();

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT id, user_id, book_id, reservation_code, reservation_date, rented FROM reservations";
                MySqlCommand command = new MySqlCommand(query, conn);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reservation reservation = new Reservation
                            {
                                Id = reader.GetInt32("id"),
                                UserId = reader.GetInt32("user_id"),
                                BookId = reader.GetInt32("book_id"),
                                ReservationCode = reader.GetString("reservation_code"),
                                ReservationDate = reader.GetDateTime("reservation_date"),
                                Rented = reader.GetBoolean("rented")
                            };

                            reservations.Add(reservation);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении списка бронирований: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return reservations;
        }
        //public static List<Reservation> GetAllReservations(int userId)
        //{
        //    List<Reservation> reservations = new List<Reservation>();

        //    using (MySqlConnection conn = GetConnection())
        //    {
        //        string query = "SELECT id, user_id, book_id, reservation_code, reservation_date, rented FROM reservations WHERE user_id = @userId";
        //        MySqlCommand command = new MySqlCommand(query, conn);
        //        command.Parameters.AddWithValue("@userId", userId);

        //        try
        //        {
        //            using (MySqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    Reservation reservation = new Reservation
        //                    {
        //                        Id = reader.GetInt32("id"),
        //                        UserId = reader.GetInt32("user_id"),
        //                        BookId = reader.GetInt32("book_id"),
        //                        ReservationCode = reader.GetString("reservation_code"),
        //                        ReservationDate = reader.GetDateTime("reservation_date"),
        //                        Rented = reader.GetBoolean("rented")
        //                    };

        //                    reservations.Add(reservation);
        //                }
        //            }
        //        }
        //        catch (MySqlException ex)
        //        {
        //            MessageBox.Show("Ошибка при получении списка бронирований: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    return reservations;
        //}
        public static List<Reservation> GetAllReservationsFromUser(int userId)
        {
            List<Reservation> reservations = new List<Reservation>();

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT id, user_id, book_id, reservation_code, reservation_date, rented FROM reservations WHERE user_id = @userId AND rented = 1";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", userId);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reservation reservation = new Reservation
                            {
                                Id = reader.GetInt32("id"),
                                UserId = reader.GetInt32("user_id"),
                                BookId = reader.GetInt32("book_id"),
                                ReservationCode = reader.GetString("reservation_code"),
                                ReservationDate = reader.GetDateTime("reservation_date"),
                                Rented = reader.GetBoolean("rented")
                            };

                            reservations.Add(reservation);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении списка бронирований: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return reservations;
        }
        public static Reservation GetCurrentReservationFromUser(int userId)
        {
            Reservation reservation = null;
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT id, user_id, book_id, reservation_code, reservation_date, rented FROM reservations WHERE user_id = @userId AND rented = 0 LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", userId);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reservation = new Reservation
                            {
                                Id = reader.GetInt32("id"),
                                UserId = reader.GetInt32("user_id"),
                                BookId = reader.GetInt32("book_id"),
                                ReservationCode = reader.GetString("reservation_code"),
                                ReservationDate = reader.GetDateTime("reservation_date"),
                                Rented = reader.GetBoolean("rented")
                            };
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении информации о бронировании: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return reservation;
        }
        public static Reservation GetReservationByCode(string reservationCode)
        {
            Reservation reservation = null;

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT id, user_id, book_id, reservation_code, reservation_date, rented FROM reservations WHERE reservation_code = @reservationCode AND rented = 0 LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@reservationCode", reservationCode);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            reservation = new Reservation
                            {
                                Id = reader.GetInt32("id"),
                                UserId = reader.GetInt32("user_id"),
                                BookId = reader.GetInt32("book_id"),
                                ReservationCode = reader.GetString("reservation_code"),
                                ReservationDate = reader.GetDateTime("reservation_date"),
                                Rented = reader.GetBoolean("rented")
                            };
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении информации о бронировании: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return reservation;
        }

        //other
        public static bool DeleteReservation(int reservationId)
        {
            bool isDeleted = false;
            using (MySqlConnection conn = GetConnection())
            {
                string query = "DELETE FROM reservations WHERE id = @reservationId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@reservationId", reservationId);

                try
                {
                    int affectedRows = command.ExecuteNonQuery();
                    isDeleted = affectedRows > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при удалении бронирования: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isDeleted;
        }
        public static bool IsReservationCodeUnique(string reservationCode)
        {
            bool isUnique = true;

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT COUNT(*) FROM reservations WHERE reservation_code = @reservationCode";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@reservationCode", reservationCode);

                try
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        isUnique = false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при проверке уникальности кода бронирования: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isUnique;
        }
        public static bool ReserveBook(int bookId, int userId, string reservationCode)
        {
            MySqlConnection conn = GetConnection();
            try
            {

                string query = @"INSERT INTO reservations (book_id, user_id, reservation_code, reservation_date)
                         VALUES (@bookId,@userId, @reservationCode, @currentDate)";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@bookId", bookId);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@reservationCode", reservationCode);
                command.Parameters.AddWithValue("@currentDate", DateTime.Now);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ошибка бронировании книги: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }


        }
        public static bool HasReservedBook(int userId)
        {
            bool hasReservedBook = false;
            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT COUNT(*) FROM reservations WHERE user_id = @userId AND rented = 0";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", userId);

                try
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        int count = Convert.ToInt32(result);
                        hasReservedBook = (count > 0);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при проверке наличия забронированной книги: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return hasReservedBook;
        }

        //RENTAL
        //get
        public static List<Rental> GetAllRentals()
        {
            List<Rental> rentals = new List<Rental>();

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT id, user_id, reservation_id, book_id, rental_date FROM rentals WHERE return_date IS NULL AND reservation_id IS NOT NULL";
                MySqlCommand command = new MySqlCommand(query, conn);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rental rental = new Rental
                            {
                                Id = reader.GetInt32("id"),
                                UserId = reader.GetInt32("user_id"),
                                ReservationId = reader.GetInt32("reservation_id"),
                                BookId = reader.GetInt32("book_id"),
                                RentalDate = reader.GetDateTime("rental_date"),
                            };
                            rentals.Add(rental);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении данных о арендах: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return rentals;
        }
        public static List<Rental> GetRentalsHistory(int userId)
        {
            List<Rental> rentals = new List<Rental>();

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT id, user_id, reservation_id, book_id, rental_date, return_date FROM rentals WHERE user_id = @userId AND return_date IS NOT NULL";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", userId);

                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rental rental = new Rental
                            {
                                Id = reader.GetInt32("id"),
                                UserId = reader.GetInt32("user_id"),
                                ReservationId = reader.GetInt32("reservation_id"),
                                BookId = reader.GetInt32("book_id"),
                                RentalDate = reader.GetDateTime("rental_date"),
                                ReturnDate = reader.GetDateTime("return_date")
                            };

                            rentals.Add(rental);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении списка аренд: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return rentals;
        }



    }
}