using ChatApp.Domain.Enums;
using ChatApp.Domain.Repositories;
using ChatApp.Domain.Factories;
using ChatApp.Presentation.Helpers;
using ChatApp.Data.Entities.Models;
namespace ChatApp.Presentation.Actions.UserActions;

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

    public static void DeleteUser(int id)
    {
        var responseResult = _userRepository.Delete(id);
        if(responseResult == ResponseResultType.Success)
            Console.WriteLine($"User with id {id} deleted successfully!\n");
        else
            Console.WriteLine("Failed to delete user, no changes saved!");

        Reader.ReadKeyToContinue();
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
    public static void UpdateUser(Users user, int id)
    {
        var responseResult = _userRepository.Update(user, id);
        if (responseResult == ResponseResultType.Success)
            Console.WriteLine($"Changes saved!\n");
        else
            Console.WriteLine("Failed to update, no changes saved!\n");
    }

}
