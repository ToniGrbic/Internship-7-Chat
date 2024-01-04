namespace ChatApp.Presentation.Helpers;

public static class Timeout
{
    public static void SetTimeout(int seconds, string message = "")
    {
        for(int i = 0; i < seconds; ++i)
        {
            if(!string.IsNullOrEmpty(message))
                Console.WriteLine(message);
            Console.WriteLine($"You are on timeout for {seconds} seconds!");
            Console.Write($"\r{seconds - i} seconds left...");
            Thread.Sleep(1000);
            Console.Clear();
        }
        
    }
}