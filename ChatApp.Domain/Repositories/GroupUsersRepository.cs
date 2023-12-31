using ChatApp.Data.Entities.Models;
using ChatApp.Data.Entities;
using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Repositories
{
    public class GroupUsersRepository : BaseRepository
    {
        public GroupUsersRepository(ChatAppDbContext dbContext) : base(dbContext)
        {

        }

        public ResponseResultType AddUser(int userId, int groupId)
        {
            var group = DbContext.Groups.Find(groupId);
            if (group is null)
            {
                return ResponseResultType.NotFound;
            }

            var groupUser = new GroupUsers
            {
                UserId = userId,
                GroupId = groupId
            };
            DbContext.GroupUsers.Add(groupUser);

            return SaveChanges();
        }
      
    }
}
