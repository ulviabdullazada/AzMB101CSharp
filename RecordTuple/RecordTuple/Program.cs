namespace RecordTuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonClass p = new PersonClass()
            //{
            //    Prop = 77
            //};
            //Console.WriteLine(p.Age);
            //Console.WriteLine(p.Prop);
            //PersonClass c1 = new PersonClass()
            //{
            //    Age = 1,
            //    Prop = 2,
            //};
            //PersonClass c2 = new PersonClass()
            //{
            //    Age = 1,
            //    Prop = 2,
            //};
            //Person p = new Person()
            //{
            //    Age = 1,
            //    Prop = 2,
            //};
            ////Console.WriteLine(c1 == c2);
            //PersonRecord r1 = new PersonRecord()
            //{
            //    Prop = 5,
            //    Age = 1,
            //};
            //PersonRecord r2 = new PersonRecord();
            //PersonRecord r3 = r1 with { Age = default};
            //r1.Age = -4;

            //Adam adam = new Adam("Mikayil", "Adilov");
            //adam = adam with { FirstName = "WereWolf" };

            //Console.WriteLine(adam);
            //Console.WriteLine(r1);
            //Console.WriteLine(r3);

            (int age, string groupName) adil = (12, "asdfasdf");
            adil.age = 20;
            adil.groupName = "840A1";
            (int age, string groupName) vugar = adil;
            (int a, int b) numbers = (10, 15);
            (int age, string groupName) rufat = Test(numbers);
            Console.WriteLine(rufat);
        }
        static (int a, string b) Test((int a, int b) nums)
        {
            return (nums.a + nums.b, "Rufat");
        }
    }

    record PersonRecord
    {
        public int Age { get; set; }
        public int Prop { get; set; }
    }

    public class PersonClass
    {
        public int Age { get; set; }
        public int Prop { get; init; } = 4;
    }
    public class Person
    {
        public int Age { get; set; }
        public int Prop { get; set; } = 4;
    }
    public record Adam(string FirstName, string LastName);
    //public record Adam
    //{
    //    public string FirstName { get; init; }
    //    public string LastName { get; init; }
    //    public Adam(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}
}