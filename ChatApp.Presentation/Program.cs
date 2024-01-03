// See https://aka.ms/new-console-template for more information
using ChatApp.Presentation.Views.Auth;
using ChatApp.Presentation.Views.Menus;
using ChatApp.Presentation.Helpers;

Console.WriteLine(
    "Welcome to ChatApp!\n" +
    "--------------------------------------------------------------------\n" +
    "-> Navigate the menu options using UP/DOWN arrow keys\n" +
    "-> To select a menu option press ENTER.\n" +
    "-> To go back to the previous menu press Q or back option in menu\n" +
    "--------------------------------------------------------------------\n"
);

Reader.ReadKeyToContinue();

var options = new List<(string, Action)>() {  
    ( "Exit", () => Environment.Exit(0) ),
    ( "Login", () => new Login() ), 
    ( "Register", () => new Register() )
};

var menu = new Menu("Start Menu", options);
menu.Start();





