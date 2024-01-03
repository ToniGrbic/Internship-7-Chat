using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Actions;
namespace ChatApp.Presentation.Views.Menus
{
    public static class UserManagmentMenus
    {
        public static readonly int CoulmnPadding = 5;
        public static void PrintAllUsersMenu(Users adminUser)
        {
            Console.Clear();

            List<(string, Action)> AllUsersItems = new()
            {
                MenuOptions.BackOption
            };

            var users = UsersActions.GetAllUsers(adminUser);
            
            if(users != null)
            {
                //find max lenght of prop items for padding
                var userNamePadding = users.Max(u => u.UserName!.Length) + CoulmnPadding;
                var emailPadding = users.Max(u => u.Email!.Length) + CoulmnPadding;
                var isAdminPadding = users.Max(u => u.IsAdmin!.ToString().Length) + CoulmnPadding;

                foreach (var user in users)
                {
                    var userName = user.UserName!.PadRight(userNamePadding);
                    var email = user.Email!.PadRight(emailPadding);
                    var isAdmin = user.IsAdmin!.ToString().PadRight(isAdminPadding);

                    var manageUserOptions = new MenuOptions(user).ManageUserOptions();

                    (string, Action) row = (
                        $"{userName}Email:{email}IsAdmin:{isAdmin}", 
                        () => new Menu("Manage user options: ", manageUserOptions).Start()
                    );
                    AllUsersItems.Add(row);
                }
            }

            var AllUsersMenu = new Menu("Enter to manage user: ", AllUsersItems);
            AllUsersMenu.Start();
        }
    }
}