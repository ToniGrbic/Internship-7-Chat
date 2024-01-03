using Microsoft.EntityFrameworkCore;
using ChatApp.Data.Entities.Models;

namespace ChatApp.Data.Seeds;

public static class DatabaseSeeder
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<Users>().HasData(
            new Users("anteAdmin@gmail.com", "123456", "AnteAdmin")
            {
                Id = 7,
                IsAdmin = true,
                IsLogged = false
            }
        );
    }
}