
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
                PrintChat();
                inputMessageText = Reader.ReadInput("Input message: ");
                if(inputMessageText == "/exit")
                    break;

                PrivateMessagesActions.CreateAndAddPrivateMessage(SenderUser!.Id, ReceiverUser!.Id, inputMessageText);
                Messages = GetMessages(SenderUser!.Id, ReceiverUser!.Id);
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
                $"PRIVATE CHAT - {ReceiverUser!.UserName}#{ReceiverUser!.Id}\n" +
                "MESSAGES:\n" +
                "*************************************************\n"
            );
            
            Writer.PrintMessages<PrivateMessages, IMessages>(Messages, SenderUser!);
        }
        public List<PrivateMessages>? GetMessages(int senderUserId, int receiverUserId)
        {
            var messages = PrivateMessagesActions.GetAllPrivateMessages(senderUserId, receiverUserId);
            return messages;
        }
    }
}