
using System.Security.Cryptography;
using ChatApp.Data.Entities;
using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;

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
    public Users? GetById(int id) => DbContext.Users.FirstOrDefault(u => u.Id == id);
    public List<Users>? GetAllWithoutLogedInUser(Users user){
        return DbContext.Users
                    .Where(u => u.Id != user.Id)    
                    .ToList();
    }

    public List<Users>? GetRecentUserChats(int userId)
    {
        var recentPrivateChats = DbContext.PrivateMessages
                                .Where(pm => pm.ReceiverUserID == userId || pm.SenderUserID == userId)
                                .Select(pm => pm.ReceiverUser)
                                .Distinct()
                                .Where(u => u.Id != userId)
                                .OrderByDescending(u => u.PrivateMessagesSent.OrderByDescending(pm => pm.SentDate).FirstOrDefault()!.SentDate)
                                .ToList();

        return recentPrivateChats;
    }

    
}