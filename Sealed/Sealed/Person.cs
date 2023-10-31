using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed
{
    internal abstract class Person
    {
        static int _id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person()
        {
            _id++;
            Id = _id;
        }
        public virtual string GetFullInfo()
        {
            return $"{Id} => {Name.ToCapitalize()} {Surname.ToCapitalize()}";
        }
        public virtual void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
