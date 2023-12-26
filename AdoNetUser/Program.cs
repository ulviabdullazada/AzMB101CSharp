using AdoNetUser.Helpers;
using AdoNetUser.Models;
using AdoNetUser.Services;

namespace AdoNetUser
{
    internal class Program
    {
        //7654B70EDD91599AF331D11D8EAAAC7D6567E2DFAD05493ABF0EFFB172D5FE042DD40F3868AA291CDC7038805620C12DAF30C1B6F4EF76E9028C3E07A76C2531
        static void Main(string[] args)
        {
            User user = new User
            {
                Name = Console.ReadLine(),
                Surname = "Test",
                Password = Console.ReadLine(),
            };
            UserService service = new UserService();
            //Console.WriteLine(user.Password.HashSHA512("salam"));
            service.Register(user);
        }
        
    }
}