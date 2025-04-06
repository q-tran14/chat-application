using DAL;
using DAL.Object;
using System;
using System.Data;

namespace BLL
{
    public class UserBL
    {
        private UserDA userDA;

        // Constructor nhận đầy đủ tham số từ tầng presentation
        public UserBL(int userID, string username, string passwordHash, byte[] avatarImage, DateTime createdAt)
        {
            userDA = new UserDA(userID, username, passwordHash, avatarImage, createdAt);
        }

        // Gọi đến các phương thức trong DAL
        public void AddUser()
        {
            userDA.AddUser();
        }

        public void UpdateUser()
        {
            userDA.UpdateUser();
        }

        public void DeleteUser()
        {
            userDA.DeleteUser();
        }

        public DataTable GetUserByID()
        {
            return userDA.GetUserByID();
        }

        public DataTable GetAllUsers()
        {
            return userDA.GetAllUsers();
        }

        // Hàm hash mật khẩu (nếu bạn cần dùng thêm ở tầng BLL)
        public static string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
        public UserO GetUserO()
        {
            return userDA.GetUserO();
        }
    }
}
