using DAL;
using System;
using System.Data;

namespace BLL
{
    public class UserStatusBL
    {
        private UserStatusDA userStatusDA;

        public UserStatusBL(int userID, DateTime lastOnline)
        {
            userStatusDA = new UserStatusDA(userID, lastOnline);
        }

        public void AddUserStatus()
        {
            userStatusDA.AddUserStatus();
        }

        public void UpdateUserStatus()
        {
            userStatusDA.UpdateUserStatus();
        }

        public void DeleteUserStatus()
        {
            userStatusDA.DeleteUserStatus();
        }

        public DataTable GetUserStatusByID()
        {
            return userStatusDA.GetUserStatusByID();
        }
    }
}
