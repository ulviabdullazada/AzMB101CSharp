namespace Polymorphism;

internal class LocalStorage : IStorage
{
    public void Delete()
    {
        Console.WriteLine("File deleted from local");
    }
    public void Get()
    {
        Console.WriteLine("Get files");
    }

    public void Save(string path)
    {
        Console.WriteLine("File saved to "+path);
    }
}
