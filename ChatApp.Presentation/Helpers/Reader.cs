 
 namespace ChatApp.Presentation.Helpers;
 using System.Net.Mail;
using System.Text.RegularExpressions;

public static class Reader
 {

    public static bool ValidateEmail(string email)
     {
        string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]{1,}@([a-zA-Z0-9-]{2,}\.)+[a-zA-Z]{3,}$";
        var match = Regex.Match(email, emailRegex);
        
        if (match.Success)
            return true;
        else
        {
            Console.WriteLine("Invalid email format! Try again.");
            return false;
        }
    }

    public static string ReadEmail(string message)
    {
        string input;
        do{
            input = ReadInput(message);
        } while (!ValidateEmail(input));
        return input;
    }

    public static string ReadInput(string message)
    {
        string input;
        bool isSuccess;
        do{
            Console.WriteLine(message);
            input = Console.ReadLine() ?? string.Empty;
            isSuccess = !string.IsNullOrEmpty(input);
            if(!isSuccess)
                Console.WriteLine("Input cannot be empty! Try again.");
        } while (!isSuccess);
        return input;
    }

    public static void ReadKeyToContinue()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
 }
 


