using DAL.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class UserDA
    {
        private UserO user;

        public UserDA(int userID, string username, string passwordHash, byte[] avatarImage, DateTime createdAt)
        {
            user = new UserO(userID, username, passwordHash, avatarImage, createdAt);
        }

        public void AddUser()
        {
            string query = "INSERT INTO Users (Username, PasswordHash, AvatarImage, CreatedAt) VALUES (@Username, @PasswordHash, @AvatarImage, @CreatedAt)";

            byte[] avatarImageBytes = user._AvatarImage ?? null;

            SqlParameter[] parameters =
            {
                new SqlParameter("@Username", user._Username),
                new SqlParameter("@PasswordHash", user._PasswordHash),
                new SqlParameter("@AvatarImage", avatarImageBytes == null ? new byte[0] : (object)avatarImageBytes),
                new SqlParameter("@CreatedAt", user._CreatedAt)
            };
            int status = UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
            
            Console.WriteLine(status);
        }

        public void UpdateUser()
        {
            string query = "UPDATE Users SET PasswordHash = @PasswordHash, AvatarImage = @AvatarImage, CreatedAt = @CreatedAt WHERE  Username = @Username";
            byte[] avatarImageBytes = user._AvatarImage ?? null;
            SqlParameter[] parameters =
            {
                new SqlParameter("@Username", user._Username),
                new SqlParameter("@PasswordHash", user._PasswordHash),
                new SqlParameter("@AvatarImage", avatarImageBytes == null ? new byte[0] : (object)avatarImageBytes),
                new SqlParameter("@CreatedAt", user._CreatedAt),
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public void DeleteUser()
        {
            string query = "DELETE FROM Users WHERE UserID = @UserID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", user._UserID)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetUserByID()
        {
            string query = "SELECT * FROM Users WHERE UserID = @UserID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", user._UserID)
            };
            return UtilitiesDatabase.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable GetAllUsers()
        {
            string query = "SELECT * FROM Users";
            return UtilitiesDatabase.Instance.ExecuteQuery(query);
        }

        public UserO GetUserO()
        {
            return user;
        }
    }
}
