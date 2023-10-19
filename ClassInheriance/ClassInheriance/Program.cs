namespace ClassInheriance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string f75Name = "Isa";
            //string f75Surname = "Aliyev";
            //byte f75Age = 20;
            //string f84Name = "Fuad";
            //string f84Surname = "Khalilov";
            //byte f84Age = 20;

            //object f75 = new
            //{
            //    Name = "Isa",
            //    Surname = "Aliyev",
            //    Age = 20
            //};
            //Console.WriteLine(f75.GetType().GetProperty("Name").GetValue(f75) + " " + f75.GetType().GetProperty("Surname").GetValue(f75));

            Person f75 = new Person("Isa", "Aliyev"); // instance
            f75.Age = 20;
            Person f84 = new Person("Faud","",20)
            {
                Name = "Fuad",
                Age = 20
            };
            Person f8c = new Person
            {
                Name = "Royal",
                Surname = "Asgarov"
            };
            Person f7n = new Person("Gamar", "Umbayeva", 20);
            Console.WriteLine(f75.GetFullInfo());
            Console.WriteLine(f84.GetFullInfo());
            Console.WriteLine(f8c.GetFullInfo());
            Console.WriteLine(f7n.GetFullInfo());

        }
    }
    class Person
    {
        //field
        public string Name;
        public string Surname;
        public int Age;

        //property

        public Person() // parameterless constructor
        {
            Console.WriteLine("Person created");
        }
        public Person(string name) : this()
        {
            Name = name;
        }
        public Person(string name, string surname) : this(name)
        {
            Surname = surname;
        }
        public Person(string name, string surname, int age) : this(name, surname)
        {
            Age = age;
        }
        //method
        public string GetFullInfo()
        {
            return $"{Name} {Surname} {Age}";
        }

        //indexer
    }
}