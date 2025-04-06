using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Object
{
    public class ChatGroupsO
    {
        private int groupID;
        private string groupName;
        private DateTime createdAt;

        public int _GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public string _GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        public DateTime _CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public ChatGroupsO(int groupID, string groupName, DateTime createdAt)
        {
            this.groupID = groupID;
            this.groupName = groupName;
            this.createdAt = createdAt;
        }
    }
}
