using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Helpers;
using ChatApp.Presentation.Actions;

namespace ChatApp.Presentation.Views.Chat
{
    public class GroupChat
    {
        public Users User { get; set; }
        public List<GroupMessages>? Messages { get; set; }
        public Groups Group { get; set; }

        public GroupChat(Users user, Groups group)
        {
            User = user;
            Group = group;
            Messages = GetMessages(group.Id);
        }

        public void Display()
        {
            string inputMessageText;
            do{
                Console.Clear();
                PrintMessages();
                inputMessageText = Reader.ReadInput("Input message: ");
                if(inputMessageText == "/exit")
                    break;

                GroupMessagesActions.CreateAndAddGroupMessage(User.Id, Group.Id, inputMessageText);
                Messages = GetMessages(Group.Id);
            } while (true);
        }

        public void PrintMessages()
        {
            if(Messages == null)
            {
                Console.WriteLine("No messages!");
                return;
            }
                
            Console.WriteLine($"Group chat - {Group.GroupName}");
            Console.WriteLine("Messages:\n");
            foreach (var message in Messages)
            {
                Console.WriteLine(
                    "*******************************"
                );
                if(message.SenderUserID == User.Id)
                    Console.Write($"YOU - {message.SentDate}: \n");
                else
                    Console.Write($"{message.SenderUser.UserName}#{message.SenderUserID} - {message.SentDate}: \n");

                var formatedMessage = Writer.AddLineBreaksToMessage(message.MessageText, 31);
                Console.WriteLine(
                    $"{formatedMessage}\n" +
                    $"*******************************\n"
                );
            }
            Console.WriteLine("*************************************************");
            Console.WriteLine("Type '/exit' to go back\n");
        }

        public List<GroupMessages>? GetMessages(int groupId)
        {
            var messages = GroupMessagesActions.GetAllGroupMessages(groupId);
            if(messages == null)
                return null;

            return messages;
        }
    }
}
