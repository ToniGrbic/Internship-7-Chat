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

    public List<Groups>? GetAllUnjoinedGroups(Users user)
    {
        var groups = DbContext.Groups
                          .Where(g => !g.GroupUsers.Any(gu => gu.UserId == user.Id))
                          .ToList();

        if (groups == null)
            return null;

        return groups;
    }


}


