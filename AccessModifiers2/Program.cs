using Models.Entities;
using t = Models.Test;

namespace AccessModifiers2;
internal class Program
{
    static void Main(string[] args)
    {
        //Person a = new Person();
        //a.Name = "A";
        //a.Surname = "B";
        //Adam z = new Adam();
        //z.Name = "A";
        //z.Surname = "B";
        //Student s = new Student();
        t.Adam a = new t.Adam();
    }
}
//namespace AccessModifiers2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//    class Test
//    {
//        //public - her yerde el chatandir.
//        public string Name;
//        //protected - yarandigi classda ve miras verdiyi classda el chatandir
//        protected int Age;
//        //private ancaq yarandigi classda, default access modifiersdir.
//        private bool _isGraduated;
//        string surname;
//        //
//        internal object A;
//    }
//}