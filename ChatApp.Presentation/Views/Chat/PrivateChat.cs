
using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Actions;
using ChatApp.Presentation.Helpers;

namespace ChatApp.Presentation.Views.Chat
{
    public class PrivateChat
    {
        public PrivateChat(Users senderUser, Users receiverUser)
        {
            SenderUser = senderUser;
            ReceiverUser = receiverUser;
            Messages = GetMessages(senderUser.Id, receiverUser.Id);
        }
        public Users? SenderUser { get; set; }

        public Users? ReceiverUser { get; set; }

        public List<PrivateMessages>? Messages { get; set; }

        public void Display()
        {
            string inputMessageText;
            do{
                Console.Clear();
                PrintMessages();
                inputMessageText = Reader.ReadInput("Input message: ");
                if(inputMessageText == "/exit")
                    break;

                PrivateMessagesActions.CreateAndAddPrivateMessage(SenderUser!.Id, ReceiverUser!.Id, inputMessageText);
                Messages = GetMessages(SenderUser!.Id, ReceiverUser!.Id);
            } while (true);
        }

        public void PrintMessages()
        {
            if(Messages == null)
            {
                Console.WriteLine("No messages!");
                return;
            }
                
            Console.WriteLine($"Private chat - {ReceiverUser!.UserName}#{ReceiverUser!.Id}");
            Console.WriteLine("Messages:\n");
            foreach (var message in Messages)
            {
                Console.WriteLine(
                    "*******************************"
                );
                if(message.SenderUserID == SenderUser!.Id)
                    Console.Write($"YOU - {message.SentDate}: \n");
                else
                    Console.Write($"{ReceiverUser.UserName}#{message.SenderUserID} - {message.SentDate}: \n");

                var formatedMessage = Writer.AddLineBreaksToMessage(message.MessageText, 31);
                Console.WriteLine(
                    $"{formatedMessage}\n" +
                    $"*******************************\n"
                );
            }
        }
        public List<PrivateMessages>? GetMessages(int senderUserId, int receiverUserId)
        {
            var messages = PrivateMessagesActions.GetAllPrivateMessages(senderUserId, receiverUserId);
            return messages;
        }
    }
}