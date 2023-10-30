using AccessModifiers.Models;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person r = new Person();
            Console.WriteLine((int)'a');
            //r.SetName("Royal");
            //r.SetSurname("Asgarov");
            //r.SetAge(12);
            //r.Name = "Royal";
            //r.Surname = "Asgerov";
            ////r.FullName = "slkafjgsljkdfg";
            //r.Prop2 = 2;
            //Console.WriteLine(r.FullName);
            //Console.WriteLine(r.GetFullInfo());
        }
    }
}