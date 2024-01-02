using ChatApp.Data.Entities.Models;
using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;
using ChatApp.Domain.Repositories;

namespace ChatApp.Presentation.Actions;

public class PrivateMessagesActions
{
    private static PrivateMessagesRepository _groupMessagesRepository = RepositoryFactory.Create<PrivateMessagesRepository>();

    public static void CreateAndAddPrivateMessage(int senderId, int receiverId, string messageText)
    {
        var newPrivateMessage = new PrivateMessages(senderId, receiverId, messageText);
        var responseResult = _groupMessagesRepository.Add(newPrivateMessage);
        if (responseResult == ResponseResultType.Success)
            Console.WriteLine($"Message sent successfully!\n");
        else
        {
            Console.WriteLine("Failed to send message, no changes saved!\n");
            Reader.ReadKeyToContinue();
        }
            
    }
}
