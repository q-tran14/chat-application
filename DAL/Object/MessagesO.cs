using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Object
{
    public class MessagesO
    {
        private int messageID;
        private int senderID;
        private int? receiverID;
        private int? groupID;
        private string content;
        private string attachmentPath;
        private DateTime sentAt;

        public int _MessageID
        {
            get { return messageID; }
            set { messageID = value; }
        }

        public int _SenderID
        {
            get { return senderID; }
            set { senderID = value; }
        }

        public int? _ReceiverID
        {
            get { return receiverID; }
            set { receiverID = value; }
        }

        public int? _GroupID
        {
            get { return groupID; }
            set { groupID = value; }
        }

        public string _Content
        {
            get { return content; }
            set { content = value; }
        }

        public string _AttachmentPath
        {
            get { return attachmentPath; }
            set { attachmentPath = value; }
        }

        public DateTime _SentAt
        {
            get { return sentAt; }
            set { sentAt = value; }
        }

        public MessagesO(int messageID, int senderID, int? receiverID, int? groupID, string content, string attachmentPath, DateTime sentAt)
        {
            this.messageID = messageID;
            this.senderID = senderID;
            this.receiverID = receiverID;
            this.groupID = groupID;
            this.content = content;
            this.attachmentPath = attachmentPath;
            this.sentAt = sentAt;
        }
    }
}
