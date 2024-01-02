using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Helpers;
using ChatApp.Presentation.Actions;
using ChatApp.Presentation.Views.Chat;

namespace ChatApp.Presentation.Views.Menus
{
    public static class PrivateChatsMenu
    {
        public static void NewPrivateMessage(Users logedInUser)
        {
            List<(string, Action)> NewPrivateMessageItems = new()
            {
                ("Back to previous menu", () => Console.Clear())
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

        public static void EnterPrivateChat(Users logedInUser, Users receiverUser)
        {
            var privateChat = new PrivateChat(logedInUser, receiverUser);
            privateChat.Display();
        }
    }
}