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
        public Users? User { get; set; }

        public MenuOptions(Users? user)
        {
            User = user;
        }

        public List<(string, Action)> GroupChatOptions()
        {
            var options = new List<(string, Action)>()
            {
                ("Create group chat", () => Console.WriteLine("TODO")),
                ("Join group chat", () => Console.WriteLine("TODO")),
                ("Print all group chats", () => Console.WriteLine("TODO")),
                ("Back to previous menu", () => Console.WriteLine("TODO"))
            };

            return options;
        }

        public List<(string, Action)> PrivateMessageOptions()
        {
            var options = new List<(string, Action)>()
            {
                ("Send private message", () => Console.WriteLine("TODO")),
                ("Print all private messages", () => Console.WriteLine("TODO")),
                ("Back to previous menu", () => Console.WriteLine("TODO"))
            };

            return options;
        }

        public List <(string, Action)> UserSettings()
        {
            var options = new List<(string, Action)>()
            {
                ("Change password", () => Console.WriteLine("TODO")),
                ("Change email", () => Console.WriteLine("TODO")),
                ("Back to previous menu", () => Console.WriteLine("TODO"))
            };

            return options;
        }

    }
}
