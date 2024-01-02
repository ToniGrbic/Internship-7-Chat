using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Helpers;
using ChatApp.Presentation.Actions;

namespace ChatApp.Presentation.Views.Chat
{
    public class GroupChat
    {
        public Users SenderUser { get; set; }
        public List<GroupMessages>? Messages { get; set; }
        public Groups Group { get; set; }

        public GroupChat(Users user, Groups group)
        {
            SenderUser = user;
            Group = group;
            Messages = GetMessages(group.Id);
        }
        
        public void Display()
        {
            string inputMessageText;
            do{
                Console.Clear();
                PrintChat();
                inputMessageText = Reader.ReadInput("Input message: ");
                if(inputMessageText == "/exit")
                    break;

                GroupMessagesActions.CreateAndAddGroupMessage(SenderUser.Id, Group.Id, inputMessageText);
                Messages = GetMessages(Group.Id);
            } while (true);
        }

        public void PrintChat()
        {
            if(Messages == null)
            {
                Console.WriteLine("No messages!");
                return;
            }
                
            Console.WriteLine(
                $"GROUP CHAT - {Group.GroupName}"+
                "MESSAGES:\n" +
                "*************************************************\n"
            );

            Writer.PrintMessages<GroupMessages, IMessages>(Messages, SenderUser);
        }

        public List<GroupMessages>? GetMessages(int groupId)
        {
            var messages = GroupMessagesActions.GetAllGroupMessages(groupId);
            return messages;
        }
    }
}
