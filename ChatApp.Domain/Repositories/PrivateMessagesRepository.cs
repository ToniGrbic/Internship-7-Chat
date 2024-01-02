using ChatApp.Data.Entities.Models;
using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;

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

        var privateMessage = new PrivateMessages(senderId, receiverId, messageText);
        
        DbContext.PrivateMessages.Add(privateMessage);

        return SaveChanges();
    }

    public List<PrivateMessages>? GetAll(int senderId, int receiverId)
    {
        var privateMessages = DbContext.PrivateMessages
            .Include(pm => pm.SenderUser)
            .Where(pm => (pm.SenderUserID == senderId && pm.ReceiverUserID == receiverId) 
                      || (pm.SenderUserID == receiverId && pm.ReceiverUserID == senderId))
            .OrderBy(pm => pm.SentDate)
            .ToList();

        return privateMessages;
    }

   
}
