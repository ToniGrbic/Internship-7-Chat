namespace ChatApp.Presentation.Views.Menus;
public class Menu
{
    private List<(string, Action)> Options;
    private int SelectedOption = 0;
    private string MenuName = null!;
    private bool ExitMenu = false;
    public bool DeleteOptionOnEnter = false;

    public Menu(string menuName, List<(string, Action)> options)
    {
        MenuName = menuName;
        Options = options;
    }

    public Menu(string menuName, List<(string, Action)> options, bool deleteoptionOnEnter)
    {
        MenuName = menuName;
        Options = options;
        DeleteOptionOnEnter = deleteoptionOnEnter;
    }

    public void Start()
    {
        PrintMenu();
        while (!ExitMenu)
        {
            SelectedOption = GetInputKeyAndSetCurrentOption();
            PrintMenu();
        }
    }

    public void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine(
            $"ChatApp - {MenuName}\n" +
            "--------------------\n"
        );

        for (int i = 0; i < Options.Count; ++i)
        {
            if (SelectedOption == i)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($"--> {i + 1}. {Options[i].Item1}");
                Console.ResetColor();
            }
            else
                Console.WriteLine($"    {i + 1}. {Options[i].Item1}");
        }
    }

    public int GetInputKeyAndSetCurrentOption()
    {
        var key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.UpArrow)
        {
            if (SelectedOption == 0)
                SelectedOption = Options.Count - 1;
            else
                SelectedOption--;
        }
        else if (key.Key == ConsoleKey.DownArrow)
        {
            if (SelectedOption == Options.Count - 1)
                SelectedOption = 0;
            else
                SelectedOption++;
        }
        else if (key.Key == ConsoleKey.Enter)
        {
            Options[SelectedOption].Item2.Invoke();
            if (DeleteOptionOnEnter)
                Options.RemoveAt(SelectedOption);
            if (SelectedOption == 0)
                ExitMenu = true;
        }
        return SelectedOption;
    }
}