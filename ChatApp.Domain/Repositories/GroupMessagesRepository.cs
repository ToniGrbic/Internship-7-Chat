
using ChatApp.Data.Entities;
using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Domain.Repositories
{
    public class GroupMessagesRepository : BaseRepository 
    {
        public GroupMessagesRepository(ChatAppDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(GroupMessages groupMessage)
        {
            DbContext.GroupMessages.Add(groupMessage);

            return SaveChanges();
        }

        public List<GroupMessages>? GetAll(int groupId)
        {
            var groupMessages = DbContext.GroupMessages
                                    .Include(gm => gm.SenderUser)
                                    .Where(gm => gm.GroupID == groupId)
                                    .OrderBy(gm => gm.SentDate)
                                    .ToList();

            if (groupMessages == null)
                return null;

            return groupMessages;
        }
    }
}
