using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ticTacToe
{
    public class DataAccess
    {
        private readonly string connectionString = "Data Source=DESKTOP-C8G69EO\\SQLEXPRESS;Initial Catalog=CARO;Integrated Security=True;";

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Chuyển đổi byte array thành chuỗi 
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool RegisterUser(string username, string email, string password)
        {
            // Mã hóa mật khẩu trước khi lưu
            string hashedPassword = HashPassword(password);

            // Chuỗi SQL dùng tham số (@...) để tránh lỗi SQL Injection
            string query = "INSERT INTO [User] (username, email, password_hash) VALUES (@username, @email, @password_hash)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Định nghĩa các tham số
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password_hash", hashedPassword);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery(); // Thực thi lệnh INSERT
                        return rowsAffected > 0; // Trả về true nếu có dòng được thêm
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý lỗi (ví dụ: username/email đã tồn tại do UNIQUE Constraint)
                        Console.WriteLine($"Database Error: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        // Bạn có thể trả về UserID để lưu trữ trạng thái đăng nhập
        public int CheckLogin(string identifier, string password) // identifier: username hoặc email
        {
            string hashedPassword = HashPassword(password);

            // Kiểm tra username HOẶC email và password hash
            string query = @"
        SELECT user_id 
        FROM [User] 
        WHERE (username = @identifier OR email = @identifier) 
          AND password_hash = @password_hash";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@identifier", identifier);
                    command.Parameters.AddWithValue("@password_hash", hashedPassword);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar(); // Lấy giá trị đầu tiên (user_id)

                        if (result != null)
                        {
                            // Đăng nhập thành công, trả về user_id
                            return Convert.ToInt32(result);
                        }
                        return -1; // Đăng nhập thất bại
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Login Error: {ex.Message}");
                        return -1;
                    }
                }
            }
        }

        public string GetUsernameById(int userId)
        {
            // Cột username trong DB của bạn là 'username'
            string query = "SELECT username FROM [User] WHERE user_id = @userId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", userId);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString(); // Trả về Username
                    }
                    return null; // Không tìm thấy
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    Console.WriteLine($"Error retrieving username: {ex.Message}");
                    return null;
                }
            }

        }

        public bool EmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE email = @email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@email", email);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool UpdatePassword(string email, string newPassword)
        {
            // PHẢI mã hóa mật khẩu mới trước khi lưu
            string newHashedPassword = HashPassword(newPassword);

            // Lưu ý: Cột mật khẩu trong DB của bạn là 'password_hash'
            string query = "UPDATE [User] SET password_hash = @newHash WHERE email = @email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@newHash", newHashedPassword);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public static string GenerateVerificationCode()
        {
            Random rand = new Random();
            // Tạo mã 6 chữ số (từ 100000 đến 999999)
            return rand.Next(100000, 999999).ToString();
        }

        public ProfileData GetProfile (int userId)
        {
            // Cập nhật: Thêm cột email vào query để hiển thị trên profile form
            string query = "SELECT username, email, elo_score, bio, avatar_path, show_elo FROM [User] WHERE user_id = @userId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", userId);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Đọc và trả về dữ liệu
                            return new ProfileData
                            {
                                Username = reader["username"].ToString(),
                                Email = reader["email"].ToString(),
                                EloScore = reader["elo_score"] as int? ?? 0, // Đảm bảo an toàn nếu ELO là NULL
                                Bio = reader["bio"].ToString(),
                                AvatarPath = reader["avatar_path"].ToString(),
                                ShowElo = reader["show_elo"] as bool? ?? false
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving profile: {ex.Message}");
                }
                return null; // Trả về null nếu không tìm thấy User hoặc có lỗi
            }
        }

        public bool UpdateProfile (int userId, string newUsername, string newBio, string newAvatarPath, bool newShowElo)
        {
            string query = @"
        UPDATE [User] 
        SET username = @name, 
            bio = @bio, 
            avatar_path = @avatar, 
            show_elo = @showElo 
        WHERE user_id = @userId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@name", newUsername);
                command.Parameters.AddWithValue("@bio", newBio);
                command.Parameters.AddWithValue("@avatar", newAvatarPath);
                command.Parameters.AddWithValue("@showElo", newShowElo);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu có 1 dòng được cập nhật
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi (ví dụ: Tên người dùng mới bị trùng/UNIQUE constraint)
                    Console.WriteLine($"Error updating profile: {ex.Message}");
                    return false;
                }
            }
        }
    }

}