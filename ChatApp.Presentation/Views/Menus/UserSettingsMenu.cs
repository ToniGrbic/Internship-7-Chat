using ChatApp.Data.Entities.Models;
using ChatApp.Presentation.Helpers;
using ChatApp.Presentation.Actions;
using System.ComponentModel.DataAnnotations;

namespace ChatApp.Presentation.Views.Menus
{
    public static class UserSettingsMenu
    {
        public static void ChangeEmailOption(Users user)
        {
            Console.Clear();
            var currentEmail = Reader.ReadInput("Input your current email: ");
            
            if(currentEmail != user.Email)
            {
                Console.WriteLine("Email is not correct!");
                Reader.ReadKeyToContinue();
                return;
            }
            Console.WriteLine("Email is correct!\n");
            var newEmail = Reader.ReadEmail("Enter new email: ");

            var ConfirmEmailChange = Reader.ReadInput(
                $"Are you sure you want to change your email to {newEmail}? (enter Y/y to confirm):\n"
            );

            if(ConfirmEmailChange.ToLower() != "y"){
                Console.WriteLine("Email change canceled!");
                Reader.ReadKeyToContinue();
                return;
            }

            user.Email = newEmail;
            UsersActions.UpdateUser(user);
            Reader.ReadKeyToContinue();
        }

        public static void ChangePasswordOption(Users user)
        {
            Console.Clear();
            var currentPassword = Reader.ReadInput("Input your current password: ");
            if(currentPassword != user.Password)
            {
                Console.WriteLine("Password is not correct!");
                Reader.ReadKeyToContinue();
                return;
            }
            Console.WriteLine("Password is correct!\n");


            var newPassword = Reader.ReadInput("Enter new password: ");
            var newPasswordConfirmation = Reader.ReadInput("Confirm new password: ");

            if(newPassword != newPasswordConfirmation)
            {
                Console.WriteLine("Passwords do not match!");
                Reader.ReadKeyToContinue();
                return;
            }
            
            var ConfirmPasswordChange = Reader.ReadInput(
                $"Are you sure you want to change your password? (enter Y/y to confirm):\n"
            );

            if(ConfirmPasswordChange.ToLower() != "y"){
                Console.WriteLine("Password change canceled!");
                Reader.ReadKeyToContinue();
                return;
            }
            user.Password = newPassword;
            UsersActions.UpdateUser(user);
            Reader.ReadKeyToContinue();
        }
    }
}