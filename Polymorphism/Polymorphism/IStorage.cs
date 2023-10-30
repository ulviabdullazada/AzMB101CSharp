namespace Polymorphism;

public interface IStorage
{
    public void Test()
    {
        Console.WriteLine("Salam");
    }
    void Save(string path);
    void Delete();
    void Get();
}
