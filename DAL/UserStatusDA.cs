using DAL.Object;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserStatusDA
    {
        private UserStatusO userStatus;

        public UserStatusDA(int userID, DateTime lastOnline)
        {
            userStatus = new UserStatusO(userID, lastOnline);
        }

        public void AddUserStatus()
        {
            string query = "INSERT INTO UserStatus (UserID, LastOnline) VALUES (@UserID, @LastOnline)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", userStatus._UserID),
                new SqlParameter("@LastOnline", userStatus._LastOnline)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public void UpdateUserStatus()
        {
            string query = "UPDATE UserStatus SET LastOnline = @LastOnline WHERE UserID = @UserID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@LastOnline", userStatus._LastOnline),
                new SqlParameter("@UserID", userStatus._UserID)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public void DeleteUserStatus()
        {
            string query = "DELETE FROM UserStatus WHERE UserID = @UserID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", userStatus._UserID)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetUserStatusByID()
        {
            string query = "SELECT * FROM UserStatus WHERE UserID = @UserID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", userStatus._UserID)
            };
            return UtilitiesDatabase.Instance.ExecuteQuery(query, parameters);
        }
    }
}
