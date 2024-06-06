using Library;
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
        public static List<Reservation> GetAllReservations(int userId)
        {
            List<Reservation> reservations = new List<Reservation>();

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT id, user_id, book_id, reservation_code, reservation_date, rented FROM reservations WHERE user_id = @userId";
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
        public static List<Reservation> GetReservationsHistory(int userId)
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
        public static Reservation GetCurrentReservationInfo(int userId)
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