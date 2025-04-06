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
    public class ChatGroupsDA
    {
        private ChatGroupsO chatGroup;

        public ChatGroupsDA(int groupID, string groupName, DateTime createdAt)
        {
            chatGroup = new ChatGroupsO(groupID, groupName, createdAt);
        }

        public void AddChatGroup()
        {
            string query = "INSERT INTO ChatGroups (GroupName, CreatedAt) VALUES (@GroupName, @CreatedAt)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@GroupName", chatGroup._GroupName),
                new SqlParameter("@CreatedAt", chatGroup._CreatedAt)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public void UpdateChatGroup()
        {
            string query = "UPDATE ChatGroups SET GroupName = @GroupName, CreatedAt = @CreatedAt WHERE GroupID = @GroupID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@GroupName", chatGroup._GroupName),
                new SqlParameter("@CreatedAt", chatGroup._CreatedAt),
                new SqlParameter("@GroupID", chatGroup._GroupID)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public void DeleteChatGroup()
        {
            string query = "DELETE FROM ChatGroups WHERE GroupID = @GroupID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@GroupID", chatGroup._GroupID)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetChatGroupByID()
        {
            string query = "SELECT * FROM ChatGroups WHERE GroupID = @GroupID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@GroupID", chatGroup._GroupID)
            };
            return UtilitiesDatabase.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable GetAllChatGroups()
        {
            string query = "SELECT * FROM ChatGroups";
            return UtilitiesDatabase.Instance.ExecuteQuery(query);
        }
    }
}
