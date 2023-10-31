using System.ComponentModel;

namespace AzMIU
{
    public class Student
    {
        private static uint _id = 1;
        public uint Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student()
        {
            Id = _id;
            _id++;
        }
        public override string ToString()
        {
            return $"{Id} => {Name} {Surname}";
        }
    }
}
