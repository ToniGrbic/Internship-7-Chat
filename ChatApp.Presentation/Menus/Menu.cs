namespace ChatApp.Presentation.Menus;
public class Menu
{
        private List<(string, Action)> Options;
        private int SelectedOption = 0;
        private string MenuName;

        public Menu(string menuName, List<(string, Action)> options)
        {
            MenuName = menuName;
            Options = options;
        }

    	public void Start()
        {
            PrintMenu(Options, SelectedOption, MenuName);
            while(true){
                SelectedOption = GetInputKeyAndSetCurrentOption(Options);
                PrintMenu(Options, SelectedOption, MenuName);
            }
        }
        public void PrintMenu(List<(string, Action)> options, int selectedOption, string MenuName)
        {
            Console.Clear();
            Console.WriteLine(
                $"ChatApp - {MenuName}\n" +
                "--------------------\n"
            );
            
            for(int i = 0; i < options.Count; ++i)
            {
                if(selectedOption == i){
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine($"--> {i + 1}. {options[i].Item1}");
                    Console.ResetColor();
                }
                else
                    Console.WriteLine($"    {i + 1}. {options[i].Item1}");
            }
        }

        public int GetInputKeyAndSetCurrentOption(List<(string, Action)> options)
        {
            var key = Console.ReadKey(true);

            if(key.Key == ConsoleKey.UpArrow)
            {
                if(SelectedOption == 0)
                    SelectedOption = options.Count - 1;
                else
                    SelectedOption--;
            }
            else if(key.Key == ConsoleKey.DownArrow)
            {
                if(SelectedOption == options.Count - 1)
                    SelectedOption = 0;
                else
                    SelectedOption++;
            }
            else if(key.Key == ConsoleKey.Enter)
                options[SelectedOption].Item2.Invoke();

            return SelectedOption;
        }

}