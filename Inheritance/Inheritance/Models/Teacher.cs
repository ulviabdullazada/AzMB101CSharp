namespace Inheritance.Models;
internal class Teacher : Person
{
    public byte Experience;
    public Teacher()
    {
        
    }
    public Teacher(string name, string surname, byte age, byte experience) : base(name, surname, age)
    {
        Experience = experience;
    }
}
