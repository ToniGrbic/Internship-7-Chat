namespace ChatApp.Presentation.Menus;
using ChatApp.Presentation.Helpers;
    public class Register
    {
        private string Email { get; set; }
        private string UserName { get; set; }
        private string Password { get; set; }
        private string ConfirmPassword { get; set; }
        private string Captcha { get; set; }
        private bool isSuccess;
        public Register()
        {
            do{
                Console.Clear();
                Email = Reader.ReadEmail("Email: ");
                UserName = Reader.ReadInput("Username: ");
                do{
                    Password = Reader.ReadInput("Password: ");
                    ConfirmPassword = Reader.ReadInput("Confirm Password: ");
                    isSuccess = ConfirmUserPassword(Password, ConfirmPassword);
                } while(!isSuccess);

                 isSuccess = CreateAndConfirmCaptchaString();

                //TODO: check if that user already is in database, if not create new user
                Reader.ReadKeyToContinue();
            } while(!isSuccess);
        }

        public bool ConfirmUserPassword(string password, string confirmPassword)
        {
            bool isSuccess = password == confirmPassword;
            if(isSuccess) 
                Console.WriteLine("\nPasswords match!");
            else
                Console.WriteLine("\nPasswords do not match!");
            Reader.ReadKeyToContinue();
            return isSuccess;
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
        public bool CreateAndConfirmCaptchaString()
        {
            bool isSuccess;
            do{
                Console.Clear();
                Captcha = CreateRandomCaptchaString(5);
                Console.WriteLine($"Captcha: {Captcha}");
                var input = Reader.ReadInput("Confirm Captcha: ");
                isSuccess = input == Captcha;
                if(isSuccess) 
                    Console.WriteLine("\nInputed captcha is correct!");
                else
                    Console.WriteLine("\nInputed captcha does not match!, try again.");
                Reader.ReadKeyToContinue();
            } while(!isSuccess);
            return isSuccess;
        }
    }
