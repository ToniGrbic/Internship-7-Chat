
namespace ChatApp.Presentation.Menus;

using ChatApp.Presentation.Actions.UserActions;
using ChatApp.Presentation.Helpers;
using ChatApp.Data.Entities.Models;

public class Login
{
    private string Email { get; set; }
    private string Password { get; set; }
    private bool IsSuccess = false;

    public Login()
    {
        do{
            Console.Clear();
            Console.WriteLine("Login:\n");
            Email = Reader.ReadEmail("Email: ");
            Password = Reader.ReadInput("Password: ");

            var user = UserActions.GetUserByEmailForLogin(Email);
            if (user is null)
            {
                Reader.ReadKeyToContinue();
                continue;
            }
                
            IsSuccess = ValidateUserPassword(user, Password);
            Reader.ReadKeyToContinue();
        } while(!IsSuccess);
    }

    public bool ValidateUserPassword(Users user, string password)
    {
        
        bool isSuccess = password == user.Password;
        if(!isSuccess)
        {
            Console.WriteLine("\nLogin failed, try again!");
            return false;
        }
        
        user.IsLogged = true;
        UserActions.UpdateUser(user, user.Id);
        Console.WriteLine("\nLogin successful!");
        return isSuccess;
    }
}