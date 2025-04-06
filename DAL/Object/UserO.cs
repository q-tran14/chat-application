using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Object
{
    public class UserO
    {
        private int userID;
        private string username;
        private string passwordHash;
        private byte[] avatarImage;
        private DateTime createdAt;

        public int _UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string _Username
        {
            get { return username; }
            set { username = value; }
        }

        public string _PasswordHash
        {
            get { return passwordHash; }
            set { passwordHash = value; }
        }

        public byte[] _AvatarImage
        {
            get { return avatarImage; }
            set { avatarImage = value; }
        }

        public DateTime _CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public UserO(int userID, string username, string passwordHash, byte[] avatarImage, DateTime createdAt)
        {
            this.userID = userID;
            this.username = username;
            this.passwordHash = passwordHash;
            this.avatarImage = avatarImage;
            this.createdAt = createdAt;
        }
    }
}
