using System.Runtime.Intrinsics.Arm;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person[] people = { 
            //    new Student { Name = "Rusif", Surname="Safarov", UniversityName = "AzMIU" }, 
            //    new Employee{ Name = "Nihad", Surname = "Cafarov", Apartment = "Sales"}, 
            //    new Teacher { Name = "Fuad", Surname="Khalilov", LessonHour = 6 } }
            //;
            //foreach (var person in people)
            //{
            //    if (person is Student s)
            //    {
            //        Console.WriteLine(s.Name + " " + s.Surname + " University -> " +
            //                s.UniversityName);
            //    }
            //    //var type = person.GetType();
            //    //switch (type.Name)
            //    //{
            //    //    case "Student":
            //    //        Console.WriteLine(person.Name + " " + person.Surname + " University ->" +
            //    //            ((Student)person).UniversityName);
            //    //        break;
            //    //    case "Employee":
            //    //        Console.WriteLine(person.Name + " " + person.Surname + " Apartment ->" +
            //    //            ((Employee)person).Apartment);
            //    //        break;
            //    //    case "Teacher":
            //    //        Console.WriteLine(person.Name + " " + person.Surname + " Lesson hour ->" +
            //    //            ((Teacher)person).LessonHour);
            //    //        break;
            //    //}

            //}
            //int a = 24;
            //string o = a.ToString();
            //object s = "222";
            //long l = Convert.ToInt64(o);
            //Dollar dollar = new Dollar(2);
            //Manat m = dollar;
            //Dollar d = new Manat(23);
            //Console.WriteLine(d.USD); 
            Person gunash = new Person
            {
                Name = "Gunash",
                Surname = "Mammadli",
                Age = 20
            };
            Person rashad = new Person
            {
                Name = "Rashad",
                Surname = "Salimov",
                Age = 20,
            };
            Person rashad2 = new Person
            {
                Name = "Rashad",
                Surname = "Salimov",
                Age = 20,
            };
            Console.WriteLine(rashad == rashad2);
        }
    }
    class Manat
    {
        public decimal AZN { get; set; }
        public Manat(decimal azn)
        {
            AZN = azn;
        }
        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.USD * 1.7m);
        }
        public static bool operator == (Dollar d, Manat m)
        {
            return m.AZN*1.7m == d.USD;
        }
        public static bool operator != (Dollar d, Manat m)
        {
            return false;
        }
    }
    class Dollar 
    {
        public decimal USD { get; set; }
        public Dollar(decimal usd)
        {
            USD = usd;
        }
        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.AZN / 1.7m);
        }
    }

}