using Exceptions.Exceptions;

namespace Exceptions;

internal class Program
{
    static void Main(string[] args)
    {
        int input;
        do
        {
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        UserService.Create(CreateUserFromConsole());
                        break;
                    case 2:
                        UserService.PrintUsers();
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } while (true);
    }
    static User CreateUserFromConsole()
    {
        User user = new User();
        Console.WriteLine("Enter Name");
        user.Name = Console.ReadLine();
        Console.WriteLine("Enter Surname");
        user.Surname = Console.ReadLine();
        Console.WriteLine("Enter Username");
        user.Username = Console.ReadLine();
        Console.WriteLine("Enter Password");
        user.Password = Console.ReadLine();
        return user;
    }
}