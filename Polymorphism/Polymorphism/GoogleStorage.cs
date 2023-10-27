namespace Polymorphism
{
    internal class GoogleStorage : IStorage
    {
        public void Delete()
        {
            Console.WriteLine("File deleted from google");
        }

        public void Get()
        {
            Console.WriteLine("Get files from google");
        }

        public void Save(string path)
        {
            Console.WriteLine("File saved google to " + path);
        }
    }
}
