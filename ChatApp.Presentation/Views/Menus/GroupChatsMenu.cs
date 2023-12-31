using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Repositories;
using ChatApp.Presentation.Helpers;
using ChatApp.Presentation.Actions;
using System.Text.RegularExpressions;

namespace ChatApp.Presentation.Views.Menus
{
    public static class GroupChatsMenu
    {
        public static void CreateGroupChat(Users user)
        {
            var groupChatName = Reader.ReadInput("Enter new group chat name: ");
            var groupID = GroupsActions.CreateGroupChat(groupChatName);
            GroupUsersActions.AddUser(user.Id, groupID);
        }

        public static void JoinGroupChat(Users user)
        {   
            List<(string, Action)> JoinGroupItems = new();
            var groups = GroupsActions.GetUnjoinedGroups(user);
            if(groups != null)
            {
                foreach (var group in groups)
                {
                    (string, Action) row = (group!.GroupName, () => AddUserToGroupChat(user.Id, group.Id));
                    JoinGroupItems.Add(row);
                }
            }
            JoinGroupItems.Insert(0, ("Back to previous menu", () => Console.Clear()));    
            
            var JoinGroupMenu = new Menu("Enter to join a group: ", JoinGroupItems, true);
            JoinGroupMenu.Start();
        }

        public static void AddUserToGroupChat(int userId, int groupId)
        {
            Console.Clear();
            GroupUsersActions.AddUser(userId, groupId);
            Reader.ReadKeyToContinue();

        }
    }
}
