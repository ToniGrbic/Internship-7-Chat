using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Actions;
using ChatApp.Presentation.Views.Chat;

namespace ChatApp.Presentation.Views.Menus
{
    public static class PrivateChatsMenus
    {
        public static void NewPrivateMessage(Users logedInUser)
        {
            List<(string, Action)> NewPrivateMessageItems = new()
            {
                MenuOptions.BackOption
            };

            var users = UsersActions.GetAllUsers(logedInUser);
            
            if(users != null)
            {
                foreach (var user in users)
                {
                    (string, Action) row = ($"{user!.UserName}#{user!.Id}", () => EnterPrivateChat(logedInUser, user));
                    NewPrivateMessageItems.Add(row);
                }
            }

            var NewPrivateMessageMenu = new Menu("Enter to start private chat with user: ", NewPrivateMessageItems);
            NewPrivateMessageMenu.Start();
        }

        public static void PrintRecentPrivateChats(Users logedInUser)
        {
            List<(string, Action)> RecentPrivateChatsItems = new()
            {
                MenuOptions.BackOption
            };

            var recentPrivateChats = UsersActions.GetRecentUserPrivateChats(logedInUser.Id);
            
            if(recentPrivateChats != null)
            {
                foreach (var user in recentPrivateChats)
                {
                    (string, Action) row = ($"{user!.UserName}#{user!.Id}", () => EnterPrivateChat(logedInUser, user));
                    RecentPrivateChatsItems.Add(row);
                }
            }

            var RecentPrivateChatsMenu = new Menu("Enter to start private chat with user: ", RecentPrivateChatsItems);
            RecentPrivateChatsMenu.Start();
        }

        public static void EnterPrivateChat(Users logedInUser, Users receiverUser)
        {
            var privateChat = new PrivateChat(logedInUser, receiverUser);
            privateChat.Display();
        }
    }
}