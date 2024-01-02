
using ChatApp.Data.Entities;
using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Repositories;

public class UsersRepository : BaseRepository
{
    public UsersRepository(ChatAppDbContext dbContext) : base(dbContext)
    {
    }

    public ResponseResultType Add(Users user)
    {
        DbContext.Users.Add(user);

        return SaveChanges();
    }

    public ResponseResultType Delete(int id)
    {
        var userToDelete = DbContext.Users.Find(id);
        if (userToDelete is null)
        {
            return ResponseResultType.NotFound;
        }

        DbContext.Users.Remove(userToDelete);

        return SaveChanges();
    }

    public ResponseResultType Update(Users user, int id)
    {
        var userToUpdate = DbContext.Users.Find(id);
        if (userToUpdate is null)
        {
            return ResponseResultType.NotFound;
        }

        userToUpdate.Email = user.Email;
        userToUpdate.UserName = user.UserName;

        return SaveChanges();
    }

    public Users? GetByEmail(string email) => DbContext.Users.FirstOrDefault(u => u.Email == email);
    public List<Users>? GetAllWithoutLogedInUser(Users user){
        return DbContext.Users
                    .Where(u => u.Id != user.Id)    
                    .ToList();
    }

    
}