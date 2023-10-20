namespace Inheritance.Models;
internal class Person
{
    public string Name;
    public string Surname;
    public byte Age;
    public Person()
    {
        Console.WriteLine("Person created");
    }

    public Person(string name, string surname, byte age) : this()
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public string GetInfo()
    {
        return $"{Name} {Surname} {Age}";
    }
}
