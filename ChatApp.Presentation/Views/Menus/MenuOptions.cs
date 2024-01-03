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
                ("Create group chat", () => GroupChatsMenu.CreateGroupChat(User)),
                ("Join group chat", () => GroupChatsMenu.JoinGroupChatMenu(User)),
                ("Print all group chats", () => GroupChatsMenu.PrintAllGroupChatsMenu(User)),
            };

            return options;
        }

        public List<(string, Action)> PrivateMessageOptions()
        {
            var options = new List<(string, Action)>()
            {
                BackOption,
                ("Send private message", () => PrivateChatsMenu.NewPrivateMessage(User)),
                ("Print recent private chats", () => PrivateChatsMenu.PrintRecentPrivateChats(User)),
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

        public List<(string, Action)> ManageUserOptions(Users user)
        {
            var options = new List<(string, Action)>()
            {
                BackOption,
                ("Delete user", () => Console.WriteLine("TODO")),
                ("Change user email", () => Console.WriteLine("TODO")),
                ("Promote user to admin", () => Console.WriteLine("TODO"))
            };

            return options;
        }

    }
}
