using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Helpers;
using ChatApp.Presentation.Actions;
using ChatApp.Presentation.Views.Chat;

namespace ChatApp.Presentation.Views.Menus
{
    public static class GroupChatsMenu
    {
        public static void CreateGroupChat(Users user)
        {
            Console.Clear();
            var groupChatName = Reader.ReadInput("Enter new group chat name: ");
            var groupID = GroupsActions.CreateGroupChat(groupChatName);
            GroupUsersActions.AddUser(user.Id, groupID);
        }

        public static void JoinGroupChatMenu(Users user)
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
        public static void PrintAllGroupChatsMenu(Users user)
        {
            Console.Clear();

            List<(string, Action)> GroupChatsItems = new();
            var joinedGroups = GroupsActions.GetJoinedGroups(user);
            if(joinedGroups != null)
            {
                foreach (var group in joinedGroups)
                {
                    (string, Action) row = (group!.GroupName, () => EnterGroupChat(user, group));
                    GroupChatsItems.Add(row);
                }
            }
            GroupChatsItems.Insert(0, ("Back to previous menu", () => Console.Clear()));
            var GroupChatsMenu = new Menu("Enter to join chat: ", GroupChatsItems);
            GroupChatsMenu.Start();

        }

        public static void AddUserToGroupChat(int userId, int groupId)
        {
            Console.Clear();
            GroupUsersActions.AddUser(userId, groupId);
            Reader.ReadKeyToContinue();
        }

        public static void EnterGroupChat(Users user, Groups group)
        {
            var groupChat = new GroupChat(user, group);
            groupChat.Display();
        }


    }
}
