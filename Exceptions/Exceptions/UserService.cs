using Exceptions.Exceptions;
namespace Exceptions
{
    internal class UserService
    {
        static List<User> Users { get; set; } = new List<User>();
        public static void Create(User user)
        {
            if (user == null) throw new ArgumentNullException(ExceptionMessages.UserNull);
            if (user.Username.Length < 4) throw new UserValidationException("Username length must be greater than 3");
            if (user.Password.Length < 6) throw new UserValidationException("Password lenth must be greater than 6");
            foreach (var existUser in Users)
            {
                if (existUser.Username == user.Username)
                {
                    throw new UserAlreadyExistException("User already exist in our app");
                }
            }
            Users.Add(user);
        }
        public static void PrintUsers()
        {
            foreach (var user in Users)
            {
                Console.WriteLine(user.Username);
            }
        }
    }
}
