using DAL;
using System;
using System.Data;

namespace BLL
{
    public class GroupMembersBL
    {
        private GroupMembersDA groupMembersDA;

        public GroupMembersBL(int groupID, int userID, DateTime joinedAt)
        {
            groupMembersDA = new GroupMembersDA(groupID, userID, joinedAt);
        }

        public void AddGroupMember()
        {
            groupMembersDA.AddGroupMember();
        }

        public void DeleteGroupMember()
        {
            groupMembersDA.DeleteGroupMember();
        }

        public DataTable GetGroupMembersByGroupID()
        {
            return groupMembersDA.GetGroupMembersByGroupID();
        }
    }
}
