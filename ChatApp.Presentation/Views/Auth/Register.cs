namespace ChatApp.Presentation.Views.Auth;
using ChatApp.Presentation.Helpers;
using ChatApp.Presentation.Actions.UserActions;
    public class Register
    {
        private string Email { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        private string ConfirmPassword { get; set; }

        private bool IsSuccess;
        public Register()
        {
            Console.Clear();
            Console.WriteLine("Register:\n");
            do{
                Email = Reader.ReadEmail("Email: ");
            }while(UsersActions.GetUserByEmailForRegister(Email) is not null);
            
            UserName = Reader.ReadInput("Username: ");
            do{
               Password = Reader.ReadInput("Password: ");
               ConfirmPassword = Reader.ReadInput("Confirm Password: ");
               ConfirmUserPassword(Password, ConfirmPassword);
            } while(!IsSuccess);

            CreateAndConfirmCaptchaString();
            UsersActions.RegisterUser(Email, UserName, Password);
        }

        public void ConfirmUserPassword(string password, string confirmPassword)
        {
            IsSuccess = password == confirmPassword;
            if(IsSuccess) 
                Console.WriteLine("\nPasswords match!");
            else
                Console.WriteLine("\nPasswords do not match!");
            Reader.ReadKeyToContinue();
        }

        public string CreateRandomCaptchaString(int length)
        {
            //Console.WriteLine("Captcha: ");
            //generete random string that contains atleast one number and one character
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            const string nums = "0123456789";
            var random = new Random();

            var randomChars = new string(Enumerable.Repeat(chars, length - 2)
            .Select(s => s[random.Next(s.Length)]).ToArray());

            var randomNumber = nums[random.Next(nums.Length)];
            var randomChar = chars[random.Next(chars.Length)];

            var randomString = randomChars.Insert(random.Next(randomChars.Length), randomNumber.ToString())
                .Insert(random.Next(randomChars.Length), randomChar.ToString());

            return randomString;
        }
        public void CreateAndConfirmCaptchaString()
        {
            do{
                Console.Clear();
                var captcha = CreateRandomCaptchaString(5);
                Console.WriteLine($"Captcha: {captcha}");

                var input = Reader.ReadInput("Confirm Captcha: ");
                IsSuccess = input == captcha;
                if(IsSuccess) 
                    Console.WriteLine("\nInputed captcha is correct!");
                else
                    Console.WriteLine("\nInputed captcha does not match!, try again.");
                Reader.ReadKeyToContinue();
            } while(!IsSuccess);
        }
    }
