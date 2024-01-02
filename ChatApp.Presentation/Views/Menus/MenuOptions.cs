using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChatApp.Data.Entities.Models;

namespace ChatApp.Presentation.Views.Menus
{
    
    public class MenuOptions
    {
        public Users User { get; set; }

        public MenuOptions(Users user)
        {
            User = user;
        }

        public List<(string, Action)> GroupChatOptions()
        {
            var options = new List<(string, Action)>()
            {
                ("Back to previous menu", () => Console.Clear()),
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
                ("Back to previous menu", () => Console.Clear()),
                ("Send private message", () => PrivateChatsMenu.NewPrivateMessage(User)),
                ("Print all private chats", () => Console.WriteLine("TODO")),
            };

            return options;
        }

        public List <(string, Action)> UserSettings()
        {
            var options = new List<(string, Action)>()
            {
                ("Back to previous menu", () => Console.Clear()),
                ("Change password", () => Console.WriteLine("TODO")),
                ("Change email", () => Console.WriteLine("TODO")),
                
            };

            return options;
        }

    }
}
