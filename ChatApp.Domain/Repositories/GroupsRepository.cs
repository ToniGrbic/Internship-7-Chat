using ChatApp.Data.Entities;
using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Repositories;

public class GroupsRepository : BaseRepository
{
    public GroupsRepository(ChatAppDbContext dbContext) : base(dbContext)
    {
    }

    public ResponseResultType AddGroup(Groups group)
    {
        DbContext.Groups.Add(group);

        return SaveChanges();
    }

    public ResponseResultType AddUserToGroup(int userId, int groupId)
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


