using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    public class Database
    {
        // Поля класса
        public static string login;
        string _dbName = "name";
        string _dbSurname = "surname";
        string _dbLastName = "lastname";
        string _dbLogin = "login";
        string _dbPassword = "password";
        string _dbIdUser = "idUser";
        string _dbStartValue = "startValue";
        string _dbStartSystem = "startSystem";
        string _dbEndValue = "endValue";
        string _dbEndSystem = "endSystem";

        int _idUser;
        SQLiteConnection _connection;
        string _connectionString;

        // Конструктор класса
        public Database()
        {
            // Получаем строку подключения из файла конфигурации
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        // Метод для регистрации пользователя
        public bool Reg(string name, string login, string password, string surname, string lastname)
        {
            bool isAuto = false;
            string query = $"INSERT INTO user ({_dbLogin}, {_dbPassword}, {_dbName}, {_dbSurname}, {_dbLastName})" +
                $" VALUES (@login, @password, @name, @surname, @lastname)";
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", ComputeSha256Hash(password));
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    if (lastname != "Введите отчество (при наличии)" && lastname != String.Empty && lastname != "")
                    {
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@lastname", "");
                    }
                    try
                    {
                        cmd.ExecuteNonQuery();
                        isAuto = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                        isAuto = false;
                    }
                }
            }
            return isAuto;
        }

        // Метод для авторизации пользователя
        public bool Login(string login, string password)
        {
            bool isAuthenticated = false;
            string query = $"SELECT COUNT(1) FROM user WHERE {_dbLogin} = @login AND {_dbPassword} = @password";

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", ComputeSha256Hash(password));

                    try
                    {
                        var result = cmd.ExecuteScalar();
                        if (Convert.ToInt32(result) > 0)
                        {
                            isAuthenticated = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        isAuthenticated = false;
                    }
                }
            }

            return isAuthenticated;
        }
        
        // Метод для получения хеша пароля
        public static string ComputeSha256Hash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Метод для получения id пользователя, который в данный момент находится в программе
        public int GetId()
        {
            string login = User.login;

            string query = $"SELECT id FROM user WHERE {_dbLogin} = @login";

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);

                    try
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (!reader.IsDBNull(0))
                                {
                                    _idUser = reader.GetInt32(0);
                                    return _idUser;
                                }
                                else
                                {
                                    MessageBox.Show("ID не найден или NULL.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пользователь с таким логином не найден.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
                    }
                }
            }
            return 0;
        }

        // Метод для загрузки истории
        public void LoadHistory(string startValue, string startSystem, string endValue, string endSystem)
        {
            _idUser = GetId();
            string query = $"INSERT INTO history ({_dbIdUser}, {_dbStartValue}, {_dbStartSystem}," +
                $" {_dbEndValue}, {_dbEndSystem})" +
                $" VALUES ({_idUser}, @startValue, @startSystem, @endValue, @endSystem)";
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue(_dbIdUser, _idUser);
                    cmd.Parameters.AddWithValue("@startValue", startValue);
                    cmd.Parameters.AddWithValue("@startSystem", startSystem);
                    cmd.Parameters.AddWithValue("@endValue", endValue);
                    cmd.Parameters.AddWithValue("@endSystem", endSystem);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
            }
        }

        // Метод для очистки истории (одинаковых строк)
        public void ClearHistory()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                    DELETE FROM history
                    WHERE startValue = endValue
                      AND startSystem = endSystem;";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        // Метод для загрузки данных из таблицы в датагрид
        public void LoadData(DataGridView dgvData)
        {

            using (var connection = new SQLiteConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"SELECT startValue, startSystem, endValue, endSystem FROM history WHERE idUser = {GetId()};";
                    using (var adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvData.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}


