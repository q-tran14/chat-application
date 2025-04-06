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
    public class MessagesDA
    {
        private MessagesO message;

        public MessagesDA(int messageID, int senderID, int? receiverID, int? groupID, string content, string attachmentPath, DateTime sentAt)
        {
            message = new MessagesO(messageID, senderID, receiverID, groupID, content, attachmentPath, sentAt);
        }

        public void AddMessage()
        {
            string query = "INSERT INTO Messages (SenderID, ReceiverID, GroupID, Content, AttachmentPath, SentAt) VALUES (@SenderID, @ReceiverID, @GroupID, @Content, @AttachmentPath, @SentAt)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@SenderID", message._SenderID),
                new SqlParameter("@ReceiverID", (object)message._ReceiverID ?? DBNull.Value),
                new SqlParameter("@GroupID", (object)message._GroupID ?? DBNull.Value),
                new SqlParameter("@Content", message._Content),
                new SqlParameter("@AttachmentPath", (object)message._AttachmentPath ?? DBNull.Value),
                new SqlParameter("@SentAt", message._SentAt)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public void DeleteMessage()
        {
            string query = "DELETE FROM Messages WHERE MessageID = @MessageID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@MessageID", message._MessageID)
            };
            UtilitiesDatabase.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetMessagesByGroupID()
        {
            string query = "SELECT * FROM Messages WHERE GroupID = @GroupID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@GroupID", message._GroupID)
            };
            return UtilitiesDatabase.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable GetMessagesByReceiverID()
        {
            string query = "SELECT * FROM Messages WHERE ReceiverID = @ReceiverID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ReceiverID", message._ReceiverID)
            };
            return UtilitiesDatabase.Instance.ExecuteQuery(query, parameters);
        }
    }
}
