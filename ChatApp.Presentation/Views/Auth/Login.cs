
namespace ChatApp.Presentation.Views.Auth;

using ChatApp.Presentation.Actions.UserActions;
using ChatApp.Presentation.Helpers;
using ChatApp.Presentation.Views.Menus;
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

            var user = UsersActions.GetUserByEmailForLogin(Email);
            if (user is null)
            {
                Reader.ReadKeyToContinue();
                continue;
            }
                
            IsSuccess = ValidateUserPassword(user, Password);
            if (!IsSuccess)
            {
                Reader.ReadKeyToContinue();
                continue;
            }
            
            var menuOptions = new MenuOptions(user);
            var groupChatOptions = menuOptions.GroupChatOptions();
            var privateMessageOptions = menuOptions.PrivateMessageOptions();
            var userSettings = menuOptions.UserSettings();

            var appActions = new List<(string, Action)>()
            {
                ("Logout", 
                 () => LogoutUser(user)),
                ("Group chats",
                 () => new Menu("Group chats", groupChatOptions).Start()),
                ("Private Messages", 
                 () => new Menu("Private messages", privateMessageOptions).Start()),
                ("Settings", 
                 () => new Menu("Settings", userSettings).Start())
            };

            if (user.IsAdmin)
                appActions.Insert(1, ("User managment", () => Console.Clear()));

            var userMenu = new Menu($"User menu - {user.UserName}", appActions);
            Console.Clear();
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
        UsersActions.UpdateUser(user, user.Id);
        Console.WriteLine("\nLogin successful!");
        return isSuccess;
    }

    public void LogoutUser(Users user)
    {
        user.IsLogged = false;
        UsersActions.UpdateUser(user, user.Id);
        Console.WriteLine("\nLogout successful!");
    }
}