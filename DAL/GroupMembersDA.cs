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
    public class GroupMembersDA
    {
        private GroupMembersO groupMember;

        public GroupMembersDA(int groupID, int userID, DateTime joinedAt)
        {
            groupMember = new GroupMembersO(groupID, userID, joinedAt);
        }

        public void AddGroupMember()
        {
            string query = "INSERT INTO GroupMembers (GroupID, UserID, JoinedAt) VALUES (@GroupID, @UserID, @JoinedAt)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@GroupID", groupMember._GroupID),
                new SqlParameter("@UserID", groupMember._UserID),
                new SqlParameter("@JoinedAt", groupMember._JoinedAt)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public void DeleteGroupMember()
        {
            string query = "DELETE FROM GroupMembers WHERE GroupID = @GroupID AND UserID = @UserID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@GroupID", groupMember._GroupID),
                new SqlParameter("@UserID", groupMember._UserID)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetGroupMembersByGroupID()
        {
            string query = "SELECT * FROM GroupMembers WHERE GroupID = @GroupID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@GroupID", groupMember._GroupID)
            };
            return UtilitiesDatabase.Instance.ExecuteQuery(query, parameters);
        }
    }
}
