using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Object
{
    public class GroupMembersO
    {
        private int groupID;
        private int userID;
        private DateTime joinedAt;

        public int _GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public int _UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public DateTime _JoinedAt
        {
            get { return joinedAt; }
            set { joinedAt = value; }
        }

        public GroupMembersO(int groupID, int userID, DateTime joinedAt)
        {
            this.groupID = groupID;
            this.userID = userID;
            this.joinedAt = joinedAt;
        }
    }
}
