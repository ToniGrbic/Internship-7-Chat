using ChatApp.Data.Entities.Models;
using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Repositories;

public class PrivateMessagesRepository : BaseRepository
{
    public PrivateMessagesRepository(ChatAppDbContext dbContext) : base(dbContext)
    {

    }

    public ResponseResultType Add(int senderId, int receiverId, string messageText)
    {
        var sender = DbContext.Users.Find(senderId);
        var receiver = DbContext.Users.Find(receiverId);
        if (sender is null || receiver is null)
        {
            return ResponseResultType.NotFound;
        }

        var privateMessage = new PrivateMessages
        {
            SenderUserID = senderId,
            ReceiverUserID = receiverId,
            MessageText = messageText,
            SentDate = DateTime.Now
        };
        DbContext.PrivateMessages.Add(privateMessage);

        return SaveChanges();
    }

    public List<PrivateMessages> GetAll(int senderId, int receiverId)
    {
        var privateMessages = DbContext.PrivateMessages
            .Where(pm => pm.SenderUserID == senderId && pm.ReceiverUserID == receiverId)
            .OrderBy(pm => pm.SentDate)
            .ToList();

        return privateMessages;
    }

   
}
