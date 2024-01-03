
using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Actions;
using ChatApp.Presentation.Helpers;
namespace ChatApp.Presentation.Views.Menus
{
    public static class UserManagmentMenus
    {
        public static readonly int CoulmnPadding = 5;
        public static List<(string,Menu)> UserManagmentMenusList = new();
        public static Menu? AllUsersMenu;
        
        public static void  PrintAllUsersMenu(Users adminUser)
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
                var RolePadding = "Admin".Length + CoulmnPadding;

                foreach (var user in users)
                {
                    var userName = user.UserName!.PadRight(userNamePadding);
                    var email = user.Email!.PadRight(emailPadding);
                    var role = (user.IsAdmin ? "Admin" : "User").PadRight(RolePadding);

                    var manageUserOptions = new MenuOptions(user).ManageUserOptions(adminUser);

                    (string, Action) row = (
                        $"{userName}{email}{role}", 
                        () => {
                            var userManageMenu = new Menu($"Manage user {user.Email}: ", manageUserOptions);
                            UserManagmentMenusList.Add((email.Trim(), userManageMenu));
                            userManageMenu.Start();
                        }
                    );
                    AllUsersItems.Add(row);
                }
            }

            AllUsersMenu = new Menu("Enter to manage user: ", AllUsersItems);
            AllUsersMenu.Start();
        }

        public static void PromoteUserToAdmin(Users adminUser, Users user)
        {
            Console.Clear();
            Writer.PrintUserInfo(user);
            var ConfirmPromoteUser = Reader.ReadInput(
                $"Are you sure you want to promote this user to admin? (enter Y/y to confirm):\n"
            );
            if(ConfirmPromoteUser.ToLower() == "y")
            {
                user.IsAdmin = true;
                UsersActions.UpdateUser(user);
                UpdatePrintAllUsersMenu(adminUser);
            }
        }

        public static void ChangeUserEmail(Users adminUser, Users user)
        {
            Console.Clear();
            Writer.PrintUserInfo(user);
            var newEmail = Reader.ReadEmail(
                $"Enter new email for user {user.UserName}:\n"
            );
            
            user.Email = newEmail;
            UsersActions.UpdateUser(user);
            UpdatePrintAllUsersMenu(adminUser);
        }

        public static void DeleteUserOption(Users adminUser, Users user)
        {
            Console.Clear();
            Writer.PrintUserInfo(user);
            var ConfirmDeleteUser = Reader.ReadInput(
                $"Are you sure you want to delete this user? (enter Y/y to confirm):\n"
            );
            if(ConfirmDeleteUser.ToLower() == "y")
            {
                UsersActions.DeleteUser(adminUser, user.Id);
                RemoveUserManageMenuOfDeletedUser(user);
                UpdatePrintAllUsersMenu(adminUser);
            }
        }
    	
        public static void RemoveUserManageMenuOfDeletedUser(Users deletedUser)
        {
            Menu deletedUserManageMenu = UserManagmentMenusList.Find(m => m.Item1 == deletedUser.Email).Item2;
            UserManagmentMenusList.Remove((deletedUser.Email, deletedUserManageMenu));
            deletedUserManageMenu.DeleteMenu();
        }

        public static void UpdatePrintAllUsersMenu(Users adminUser)
        {
            AllUsersMenu!.DeleteMenu();
            AllUsersMenu = null;
            Reader.ReadKeyToContinue();
            PrintAllUsersMenu(adminUser);
        }
    }
}