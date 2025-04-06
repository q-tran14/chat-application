using DAL;
using System;
using System.Data;

namespace BLL
{
    public class ChatGroupsBL
    {
        private ChatGroupsDA chatGroupsDA;

        public ChatGroupsBL(int groupID, string groupName, DateTime createdAt)
        {
            chatGroupsDA = new ChatGroupsDA(groupID, groupName, createdAt);
        }

        public void AddChatGroup()
        {
            chatGroupsDA.AddChatGroup();
        }

        public void UpdateChatGroup()
        {
            chatGroupsDA.UpdateChatGroup();
        }

        public void DeleteChatGroup()
        {
            chatGroupsDA.DeleteChatGroup();
        }

        public DataTable GetChatGroupByID()
        {
            return chatGroupsDA.GetChatGroupByID();
        }

        public DataTable GetAllChatGroups()
        {
            return chatGroupsDA.GetAllChatGroups();
        }
    }
}
