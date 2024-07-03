using Library.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Library
{
    internal class DbUser
    {
        //registration
        public static int Login(string login, string password)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                password = md5.hashPassword(password);

                string query = "SELECT role_id FROM users WHERE login = @login AND password = @password";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    int roleId = Convert.ToInt32(result);
                    return roleId;
                }
                else if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Введены не все данные", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; // Возвращаем -1 в случае ошибки входа
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка входа: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool Register(string name, string login, string email, string password, string passwordRepeat)
        {

            MySqlConnection conn = GetConnection();
            try
            {
                password = md5.hashPassword(password);
                passwordRepeat = md5.hashPassword(passwordRepeat);
                string checkQueryLogin = "SELECT COUNT(*) FROM users WHERE login = @login";
                MySqlCommand checkCommandLogin = new MySqlCommand(checkQueryLogin, conn);
                checkCommandLogin.Parameters.AddWithValue("@login", login);
                int countLogin = Convert.ToInt32(checkCommandLogin.ExecuteScalar());
                if (countLogin > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован", "Ошибка регистрации");
                    return false;
                }
                string checkQueryEmail = "SELECT COUNT(*) FROM users WHERE email = @email";
                MySqlCommand checkCommandEmail = new MySqlCommand(checkQueryEmail, conn);
                checkCommandEmail.Parameters.AddWithValue("@email", email);
                int count = Convert.ToInt32(checkCommandEmail.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Пользователь с таким email уже зарегистрирован", "Ошибка регистрации");
                    return false;
                }

                string query = "INSERT INTO users (name, login, email, password, role_id) VALUES (@name, @login, @email, @password, 3)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Успешная регистрация", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка при регистрации", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации: " + ex.Message, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool Register(string name, string login, string email, string password, int roleId)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string checkQueryLogin = "SELECT COUNT(*) FROM users WHERE login = @login";
                MySqlCommand checkCommandLogin = new MySqlCommand(checkQueryLogin, conn);
                checkCommandLogin.Parameters.AddWithValue("@login", login);
                int countLogin = Convert.ToInt32(checkCommandLogin.ExecuteScalar());
                if (countLogin > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован", "Ошибка регистрации");
                    return false;
                }

                string checkQueryEmail = "SELECT COUNT(*) FROM users WHERE email = @email";
                MySqlCommand checkCommandEmail = new MySqlCommand(checkQueryEmail, conn);
                checkCommandEmail.Parameters.AddWithValue("@email", email);
                int count = Convert.ToInt32(checkCommandEmail.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Пользователь с таким email уже зарегистрирован", "Ошибка регистрации");
                    return false;
                }

                string query = "INSERT INTO users (name, login, email, password, role_id) VALUES (@name, @login, @email, @password, @id)";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@id", roleId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Пользователь добавлен", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении пользоватлея", "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении пользоватлея: " + ex.Message, "Добавление пользователя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        
        //edit & delete
        public static bool DeleteUser(int userId)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "DELETE FROM users WHERE id = @userId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", userId);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true; // Пользователь успешно удален
                }
                else
                {
                    return false; // Пользователь не найден или произошла ошибка при удалении
                }
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
        public static bool EditUserInfo(int userId, string name, string login, string email, int roleId)
        {
            MySqlConnection conn = GetConnection();


            try
            {
                string checkQueryLogin = "SELECT COUNT(*) FROM users WHERE login = @login";
                MySqlCommand checkCommandLogin = new MySqlCommand(checkQueryLogin, conn);
                checkCommandLogin.Parameters.AddWithValue("@login", login);
                int countLogin = Convert.ToInt32(checkCommandLogin.ExecuteScalar());
                if (countLogin > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован", "Ошибка регистрации");
                    return false;
                }

                string checkQueryEmail = "SELECT COUNT(*) FROM users WHERE email = @email";
                MySqlCommand checkCommandEmail = new MySqlCommand(checkQueryEmail, conn);
                checkCommandEmail.Parameters.AddWithValue("@email", email);
                int count = Convert.ToInt32(checkCommandEmail.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Пользователь с таким email уже зарегистрирован", "Ошибка регистрации");
                    return false;
                }

                string query = "UPDATE users SET name = @name, login = @login, email = @email,role_id = @id WHERE id = @userId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@id", roleId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при редактировании пользователя: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool EditUserInfo(int id, string login, string email)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string checkQueryLogin = "SELECT COUNT(*) FROM users WHERE login = @login";
                MySqlCommand checkCommandLogin = new MySqlCommand(checkQueryLogin, conn);
                checkCommandLogin.Parameters.AddWithValue("@login", login);
                int countLogin = Convert.ToInt32(checkCommandLogin.ExecuteScalar());
                if (countLogin > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован", "Ошибка регистрации");
                    return false;
                }
                string checkQueryEmail = "SELECT COUNT(*) FROM users WHERE email = @email";
                MySqlCommand checkCommandEmail = new MySqlCommand(checkQueryEmail, conn);
                checkCommandEmail.Parameters.AddWithValue("@email", email);
                int count = Convert.ToInt32(checkCommandEmail.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Пользователь с таким email уже зарегистрирован", "Ошибка регистрации");
                    return false;
                }

                string query = "UPDATE users SET login = @login, email = @email WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@email", email);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Информация обновлена", "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка при изменении профиля", "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении профиля: " + ex.Message, "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool EditUserLogin(int id, string login)
        {

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Введены не все данные", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            MySqlConnection conn = GetConnection();
            try
            {
                string checkQueryLogin = "SELECT COUNT(*) FROM users WHERE login = @login";
                MySqlCommand checkCommandLogin = new MySqlCommand(checkQueryLogin, conn);
                checkCommandLogin.Parameters.AddWithValue("@login", login);
                int countLogin = Convert.ToInt32(checkCommandLogin.ExecuteScalar());
                if (countLogin > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже зарегистрирован", "Ошибка регистрации");
                    return false;
                }

                string query = "UPDATE users SET login = @login WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@login", login);


                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Информация обновлена", "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка при изменении профиля", "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении профиля: " + ex.Message, "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool EditUserEmail(int id, string email)
        {

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Введены не все данные", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            MySqlConnection conn = GetConnection();
            try
            {
                string checkQueryEmail = "SELECT COUNT(*) FROM users WHERE email = @email";
                MySqlCommand checkCommandEmail = new MySqlCommand(checkQueryEmail, conn);
                checkCommandEmail.Parameters.AddWithValue("@email", email);
                int countEmail = Convert.ToInt32(checkCommandEmail.ExecuteScalar());
                if (countEmail > 0)
                {
                    MessageBox.Show("Пользователь с таким email уже зарегистрирован", "Ошибка регистрации");
                    return false;
                }

                string query = "UPDATE users SET email = @email WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@email", email);


                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Информация обновлена", "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка при изменении профиля", "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении профиля: " + ex.Message, "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool EditUserPasswordByLogin(string login, string password)
        {
            password = md5.hashPassword(password);

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "UPDATE users SET password = @password WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@login", login);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Пароль успешно изменен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка при изменении пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении пароля: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool EditUserName(int id, string name)
        {

            MySqlConnection conn = GetConnection();
            try
            {

                string query = "UPDATE users SET name = @name WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Информация обновлена", "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка при изменении профиля", "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении профиля: " + ex.Message, "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }



        }
        public static bool EditUserRole(int id, int roleId)
        {

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "UPDATE users SET role_id = @roleId WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@roleId", roleId);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Информация обновлена", "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка при изменении профиля", "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении профиля: " + ex.Message, "Изменение профиля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        
        //check
        public static bool CheckEmail(string email)
        {
            MySqlConnection conn = GetConnection();
            try
            {

                string query = "SELECT COUNT(*) FROM users WHERE email = @email";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@email", email);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке email: " + ex.Message, "Ошибка");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool CheckLogin(string login)
        {
            MySqlConnection conn = GetConnection();
            try
            {

                string query = "SELECT COUNT(*) FROM users WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@login", login);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке login: " + ex.Message, "Ошибка");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public static bool EmailAssociatedWithLogin(string email, string login)
        {
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT COUNT(*) FROM users WHERE email = @email AND login = @login";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@login", login);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке email и login: " + ex.Message, "Ошибка");
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        //get
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
        public static List<UserClass> GetAllUsers()
        {
            List<UserClass> users = new List<UserClass>();

            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT users.id, users.name, users.login, users.email, users.role_id FROM users";
                MySqlCommand command = new MySqlCommand(query, conn);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserClass user = new UserClass
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Login = reader.GetString("login"),
                            Email = reader.GetString("email"),
                            RoleId = reader.GetInt32("role_id")
                        };

                        users.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении пользователей: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return users;
        }

        //public static Dictionary<int, Dictionary<string, object>> GetAllUsers()
        //{
        //    Dictionary<int, Dictionary<string, object>> usersDict = new Dictionary<int, Dictionary<string, object>>();

        //    MySqlConnection conn = GetConnection();
        //    try
        //    {
        //        string query = "SELECT users.id, users.name, users.login, users.email, roles.name AS role FROM users INNER JOIN roles ON users.role_id = roles.id";
        //        MySqlCommand command = new MySqlCommand(query, conn);
        //        using (MySqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                int id = reader.GetInt32("id");
        //                string name = reader.GetString("name");
        //                string login = reader.GetString("login");
        //                string email = reader.GetString("email");
        //                string role = reader.GetString("role");

        //                Dictionary<string, object> userData = new Dictionary<string, object>
        //                    {
        //                        { "id", id },
        //                        { "name", name },
        //                        { "login", login },
        //                        { "email", email },
        //                        { "role", role }
        //                    };

        //                usersDict.Add(id, userData);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ошибка при получении пользователей: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return usersDict;
        //}
        public static UserClass GetUserInfoByLogin(string login)
        {
            UserClass userInfo = new UserClass();
            MySqlConnection conn = GetConnection();
            try
            {
                string query = "SELECT id, name, email, password, role_id FROM users WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@login", login);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string name = reader.GetString("name");
                        string email = reader.GetString("email");
                        string password = reader.GetString("password");
                        int roleId = reader.GetInt32("role_id");
                        userInfo.Id = id;
                        userInfo.Name = name;
                        userInfo.Login = login;
                        userInfo.Email = email;
                        userInfo.Password = password;
                        userInfo.RoleId = roleId;
                    }
                };

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке email: " + ex.Message, "Ошибка");
            }
            finally
            {
                conn.Close();
            }
            return userInfo;

        }
        public static int GetRoleId(string roleName)
        {
            int roleId = -1;
            MySqlConnection conn = GetConnection();
            string query = "SELECT id FROM roles WHERE name = @roleName";
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@roleName", roleName);
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    roleId = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении ID роли: " + ex.Message, "Ошибка");
            }
            finally
            {
                conn.Close();
            }
            return roleId;
        }
        public static string GetRoleName(int roleId)
        {
            string roleName = "";
            MySqlConnection conn = GetConnection();
            string query = "SELECT name FROM roles WHERE id = @id";
            try
            {

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@id", roleId);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    roleName = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении названия роли: " + ex.Message, "Ошибка");
            }
            finally
            {
                conn.Close();
            }
            return roleName;
        }
        public static string GetUserNameById(int userId)
        {
            string userName = "";

            using (MySqlConnection conn = GetConnection())
            {
                string query = "SELECT name FROM users WHERE id = @userId";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", userId);

                try
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        userName = result.ToString();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при получении имени пользователя: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return userName;
        }
    }
}
