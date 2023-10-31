namespace Models.Entities;
public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    internal int Age { get; set; }
    protected private int Height { get; set; }
    internal protected int Width { get; set; }
}
internal class Another:Person
{
    public Another()
    {
        Height = 100;
        Person p = new Person();
        p.Name = Name;
        p.Surname = Surname;
        p.Age = Age;
    }
    public int Prop { get; set; }
}
