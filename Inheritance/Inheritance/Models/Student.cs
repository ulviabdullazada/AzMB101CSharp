namespace Inheritance.Models;
internal class Student : Person
{
    public byte Course;
    public string Group;
    public Student(string Name, string Surname, byte Age, byte Course, string Group):base(Name, Surname, Age)
    {
        this.Course = Course;
        this.Group = Group;
    }
}
