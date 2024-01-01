using ChatApp.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Presentation.Views.Chat
{
    public class GroupChat
    {
        public Users User { get; set; }

        public List<GroupMessages> Messages { get; set; }

        public Groups Group { get; set; }
        public GroupChat(Users user, List<GroupMessages> messages, Groups group)
        {
            User = user;
            Messages = messages;
            Group = group;
        }

        public void Display()
        {
            Console.WriteLine($"Group chat - {Group.GroupName}");
            Console.WriteLine("Messages:\n");
            foreach (var message in Messages)
            {
                if(message.SenderUserID == User.Id)
                {
                    Console.Write("You: ");
                }
                else
                {
                    Console.Write($"{message.SenderUserID}: ");
                }
                Console.WriteLine($" {message.MessageText}");
            }
        }
    }
}
