
namespace ChatApp.Presentation.Menus;
using ChatApp.Presentation.Helpers;

public class Login
{
    private string Email { get; set; }
    private string Password { get; set; }
    private bool isSuccess;

    public Login()
    {
        do{
            Console.Clear();
            Email = Reader.ReadEmail("Email: ");
            Password = Reader.ReadInput("Password: ");

            isSuccess = ValidateUserPassword(Email, Password);
            Reader.ReadKeyToContinue();
        } while(!isSuccess);
    }

    public bool ValidateUserPassword(string email, string password)
    {
        //TODO: fetch user eamil and password from database
        string userPass = "userpass";
        bool isSuccess = password == userPass;
        if(isSuccess) 
            Console.WriteLine("\nLogin successful!");
        else
            Console.WriteLine("\nLogin failed!");
        return isSuccess;
    }
}