using ChatApp.Domain.Enums;
using ChatApp.Domain.Repositories;
using ChatApp.Domain.Factories;
using ChatApp.Presentation.Helpers;
using ChatApp.Data.Entities.Models;
namespace ChatApp.Presentation.Actions;

public static class UsersActions
{
    private static UsersRepository _userRepository = RepositoryFactory.Create<UsersRepository>();
    public static void RegisterUser(string email, string userName, string password)
    {
         Users newUser = new(email, password, userName);
         var responseResult = _userRepository.Add(newUser);
   
         if(responseResult == ResponseResultType.Success)
            Console.WriteLine($"User {userName} registered successfully!\n");
         else
            Console.WriteLine("Failed to register user, no changes saved!");
         Reader.ReadKeyToContinue();
    }

    public static void DeleteUser(Users adminUser, int userId)
    {
        if(!adminUser.IsAdmin){
            Console.WriteLine("You are not an admin, delete action is not prohibited\n");
            return;
        }
        
        var user = _userRepository.GetById(userId);
        if(user is null)
        {
            Console.WriteLine($"User with id {userId} does not exist!");
            return;
        }
        
        var responseResult = _userRepository.Delete(userId);
        if(responseResult == ResponseResultType.Success)
            Console.WriteLine($"User with id {userId} deleted successfully!\n");
        else
            Console.WriteLine("Failed to delete user, no changes saved!");
    }

    public static Users? GetUserByEmailForRegister(string email)
    {
        var user = _userRepository.GetByEmail(email);
        if(user is not null)
            Console.WriteLine($"User with email {email} already exists!");
        return user!;
    }

    public static Users? GetUserByEmailForLogin(string email)
    {
        var user = _userRepository.GetByEmail(email);
        if(user is null)
            Console.WriteLine($"User with email {email} does not exist!");
        return user!;
    }
    public static void UpdateUser(Users user)
    {
        var responseResult = _userRepository.Update(user);
        if (responseResult == ResponseResultType.Success)
            Console.WriteLine($"Changes saved!\n");
        else
            Console.WriteLine("Failed to update, no changes saved!\n");
    }

    public static List<Users>? GetAllUsers(Users user)
    {
        var users = _userRepository.GetAllWithoutLogedInUser(user);
        if(users == null)
        {
            Console.WriteLine("No users found!");
            return null;
        }
        return users;
    }

    public static List<Users>? GetRecentUserPrivateChats(int userId)
    {
        var users = _userRepository.GetRecentUserChats(userId);
        if(users == null)
        {
            Console.WriteLine("No users found!");
            return null;
        }
        return users;
    }

}
