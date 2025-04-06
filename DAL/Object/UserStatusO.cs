using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Object
{
    public class UserStatusO
    {
        private int userID;
        private DateTime lastOnline;

        public int _UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public DateTime _LastOnline
        {
            get { return lastOnline; }
            set { lastOnline = value; }
        }

        public UserStatusO(int userID, DateTime lastOnline)
        {
            this.userID = userID;
            this.lastOnline = lastOnline;
        }
    }
}
