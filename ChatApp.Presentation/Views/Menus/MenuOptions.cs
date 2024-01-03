using ChatApp.Data.Entities.Models;

namespace ChatApp.Presentation.Views.Menus
{
    
    public class MenuOptions
    {
        public Users User { get; set; }
        public static (string, Action) BackOption = ("Back to previous menu", () => Console.Clear());
        public MenuOptions(Users user)
        {
            User = user;
        }

        public List<(string, Action)> GroupChatOptions()
        {
            var options = new List<(string, Action)>()
            {
                BackOption,
                ("Create group chat", () => GroupChatsMenus.CreateGroupChat(User)),
                ("Join group chat", () => GroupChatsMenus.JoinGroupChatMenu(User)),
                ("Print all group chats", () => GroupChatsMenus.PrintAllGroupChatsMenu(User)),
            };

            return options;
        }

        public List<(string, Action)> PrivateMessageOptions()
        {
            var options = new List<(string, Action)>()
            {
                BackOption,
                ("Send private message", () => PrivateChatsMenus.NewPrivateMessage(User)),
                ("Print recent private chats", () => PrivateChatsMenus.PrintRecentPrivateChats(User)),
            };

            return options;
        }

        public List <(string, Action)> UserSettings()
        {
            var options = new List<(string, Action)>()
            {
                BackOption,
                ("Change password", () => Console.WriteLine("TODO")),
                ("Change email", () => Console.WriteLine("TODO")),
                
            };

            return options;
        }

        public List<(string, Action)> ManageUserOptions(Users adminUser)
        {
            var options = new List<(string, Action)>()
            {
                BackOption,
                ("Delete user", () => UserManagmentMenus.DeleteUserOption(adminUser, User)),
                ("Change user email", () => Console.WriteLine("TODO")),
                ("Promote user to admin", () => UserManagmentMenus.PromoteUserToAdmin(adminUser, User)),
                
            };

            return options;
        }

    }
}
