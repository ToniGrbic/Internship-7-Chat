using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Enums;
using ChatApp.Domain.Repositories;
using ChatApp.Domain.Factories;
using ChatApp.Presentation.Helpers;

namespace ChatApp.Presentation.Actions;

public class PrivateMessagesActions
{
    private static PrivateMessagesRepository _privateMessagesRepository = RepositoryFactory.Create<PrivateMessagesRepository>();

    public static void CreateAndAddPrivateMessage(int senderId, int receiverId, string messageText)
    {
        var responseResult = _privateMessagesRepository.Add(senderId, receiverId, messageText);
        if (responseResult == ResponseResultType.Success)
            Console.WriteLine($"Message sent successfully!\n");
        else
        {
            Console.WriteLine("Failed to send message, no changes saved!\n");
            Reader.ReadKeyToContinue();
        }
            
    }

    public static List<PrivateMessages>? GetAllPrivateMessages(int senderId, int receiverId)
    {
        var privateMessages = _privateMessagesRepository.GetAll(senderId, receiverId);
        if (privateMessages == null)
        {
            Console.WriteLine("No messages!");
            return null;
        }
        return privateMessages!;
    }
}
