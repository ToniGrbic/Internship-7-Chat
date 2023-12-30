
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

            var appActions = new List<(string, Action)>()
            {
                ("Join Group", () => Console.WriteLine("TODO")),
                ("Send Private Message", () => Console.WriteLine("TODO")),
                ("Enter Group Chat", () => Console.WriteLine("TODO")), 
                ("Create Group", () => Console.WriteLine("TODO")),
                ("Settings", () => Console.WriteLine("TODO")),
                ("Logout", () => LogoutUser(user))
            };

            var userMenu = new Menu($"User menu - {user.UserName}", appActions);
            userMenu.Start();
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

    public void LogoutUser(Users user)
    {
        user.IsLogged = false;
        UserActions.UpdateUser(user, user.Id);
        Console.WriteLine("\nLogout successful!");
    }
}