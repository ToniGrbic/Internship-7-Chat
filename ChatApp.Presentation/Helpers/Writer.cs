namespace ChatApp.Presentation.Helpers;
using ChatApp.Data.Entities.Models;

public static class Writer
{
    public static void PrintUserInfo(Users user)
    {
        Console.WriteLine(
            $"User: {user.UserName}\n" +
            $"Email: {user.Email}\n" +
            $"Is admin: {user.IsAdmin}\n" +
            $"Is logged in: {user.IsLogged}\n"
        );
    }
}