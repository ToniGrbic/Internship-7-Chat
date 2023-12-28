 namespace ChatApp.Presentation.Helpers;
 using System.Net.Mail;
 public static class Reader
 {

    public static bool ValidateEmail(string email)
    {
        var isVaild = true;
        try{
            var addr = new MailAddress(email);
        }
        catch{
            isVaild = false;
            Console.WriteLine("Invalid email format! Try again.");
        }
        return isVaild;    
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
 


