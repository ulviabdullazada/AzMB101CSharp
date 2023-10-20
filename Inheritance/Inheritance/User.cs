namespace Inheritance
{
    internal class User
    {
        public string Username;
        public string Password;
        public bool IsLoggedIn = false;

        public void Login()
        {
            if(IsLoggedIn)
            {
                Console.WriteLine("User already logged in!");
            }
            else
            {
                IsLoggedIn = true;
                Console.WriteLine("User logged in!");
            }
        }
        public void Logout()
        {
            if(IsLoggedIn)
            {
                IsLoggedIn=false;
                Console.WriteLine("User logged out!");
            }
            else
            {
                Console.WriteLine("No one logged in!");
            }
        }
        public void Main()
        {
            Console.WriteLine("Salam");
        }

    }
}
