using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public static bool operator > (Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }
        public static bool operator < (Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
        public static bool operator >= (Person p1, Person p2)
        {
            return p1.Age >= p2.Age;
        }
        public static bool operator <= (Person p1, Person p2)
        {
            return p1.Age <= p2.Age;
        }
        public static bool operator == (Person p1, Person p2)
        {
            //if (p1.Name != p2.Name)
            //    return false;
            //if (p1.Surname != p2.Surname)
            //    return false;
            //if (p1.Age != p2.Age)
            //    return false;
            var props = p1.GetType().GetProperties();
            for (int i = 0; i < props.Length; i++)
            {
                if (props[i].GetValue(p1).ToString() != props[i].GetValue(p2).ToString())
                    return false;
            }
            return true;
        }
        public static bool operator != (Person p1, Person p2)
        {
            return !(p1 == p2);
        }
        public static int operator +(Person p1, Person p2)
        {
            return p1.Age + p2.Age;
        }
    }
}
