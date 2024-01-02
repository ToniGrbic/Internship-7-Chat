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

    public static void PrintMessages<T,U>(List<T> Messages, Users SenderUser) where T : IMessages
    {
        foreach (var message in Messages)
        {
            Console.WriteLine(
                "*********************************"
            );
            if (message.SenderUserID == SenderUser.Id)
                Console.Write($"YOU - {message.SentDate}: \n");

            else
                Console.Write($"{message.SenderUser.UserName}#{message.SenderUserID} - {message.SentDate}: \n");

            Console.WriteLine("---------------------------------");
            var formatedMessage = AddLineBreaksToMessage(message.MessageText, 32);
            Console.WriteLine(
                $"{formatedMessage}\n" +
                $"*********************************\n"
            );
        }
        Console.WriteLine("*************************************************");
        Console.WriteLine("Type '/exit' to go back\n");
    }

    public static string AddLineBreaksToMessage(string message, int maxCharactersPerLine)
    {
        string[] words = message.Split(' ');

        int currentLineLength = 0;
        string formattedMessage = "";

        foreach (string word in words)
        {
            if (currentLineLength + word.Length + 1 > maxCharactersPerLine)
            {
                formattedMessage += Environment.NewLine;
                currentLineLength = 0;
            }
            
            if (word.Length > maxCharactersPerLine)
            {
                // If the word itself is longer than the maxCharactersPerLine
                // Insert a newline character within the word at the specified index
                int index = maxCharactersPerLine;
                string newWord = word.Insert(index, Environment.NewLine);
                formattedMessage += newWord;
            }
            else
            {
                // Add the word normally
                formattedMessage += word + " ";
                currentLineLength += word.Length + 1;
            }
        }

        formattedMessage = formattedMessage.TrimEnd();
        return formattedMessage;
    }

}
