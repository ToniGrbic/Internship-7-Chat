using ChatApp.Domain.Enums;
using ChatApp.Domain.Repositories;
using ChatApp.Domain.Factories;
using ChatApp.Presentation.Helpers;
using ChatApp.Data.Entities.Models;
namespace ChatApp.Presentation.Actions.UserActions;

public static class UserActions
{
    private static UsersRepository _userRepository = RepositoryFactory.Create<UsersRepository>();
    public static void AddUser(string email, string userName, string password)
    {
         Users newUser = new(email, password, userName);
         var responseResult = _userRepository.Add(newUser);
   
         if(responseResult == ResponseResultType.Success)
            Console.WriteLine($"User {userName} added successfully!\n");
         else
            Console.WriteLine("Failed to add user, no changes saved!");

        Reader.ReadKeyToContinue();
    }

}
