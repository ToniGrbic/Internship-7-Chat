// See https://aka.ms/new-console-template for more information
using ChatApp.Presentation.Menus;

Console.WriteLine("Welcome to ChatApp!\n");

var options = new List<(string, Action)>() { 
    ( "Login", () => new Login() ), 
    ( "Register", () => new Register() ), 
    ( "Exit", () => Environment.Exit(0) )
};
var menu = new Menu("Start Menu", options);
menu.Start();





