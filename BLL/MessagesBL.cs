using DAL;
using System;
using System.Data;

namespace BLL
{
    public class MessagesBL
    {
        private MessagesDA messagesDA;

        public MessagesBL(int messageID, int senderID, int? receiverID, int? groupID, string content, string attachmentPath, DateTime sentAt)
        {
            messagesDA = new MessagesDA(messageID, senderID, receiverID, groupID, content, attachmentPath, sentAt);
        }

        public void AddMessage()
        {
            messagesDA.AddMessage();
        }

        public void DeleteMessage()
        {
            messagesDA.DeleteMessage();
        }

        public DataTable GetMessagesByGroupID()
        {
            return messagesDA.GetMessagesByGroupID();
        }

        public DataTable GetMessagesBySenderID()
        {
            return messagesDA.GetMessagesBySenderID();
        }
    }
}
