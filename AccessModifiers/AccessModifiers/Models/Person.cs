using System.Xml.Linq;

namespace AccessModifiers.Models
{
    public class Person
    {
        private string _password;

        public string Password
        {
            get { return _password; }
            set { 
                if (HasDigit(value)) {
                    _password = value;
                }
            }
        }
        private bool HasDigit(string str)
        {
            foreach (char c in str)
            {
                if (char.IsDigit(c)) 
                {
                    return true;
                }
            }
            return false;
        }
        //private string _name;
        //private string _surname;
        //private byte _age;
        //public const bool IsMale = true;
        //public Person(bool isMale)
        //{
        //    IsMale = isMale;
        //}
        //public string Name {
        //    get
        //    {
        //        if (_name == null)
        //        {
        //            _name = "Nese daxil edilmeyib";
        //        }
        //        return _name;
        //    }
        //    set 
        //    {
        //        if (!String.IsNullOrWhiteSpace(value) && value.Length >= 3)
        //        {
        //            _name = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Olmaz!");
        //        }
        //    } 
        //}
        //public string Surname
        //{
        //    get
        //    {
        //        if (_surname == null)
        //        {
        //            _surname = "Nese daxil edilmeyib";
        //        }
        //        return _surname;
        //    }
        //    set
        //    {
        //        if (!String.IsNullOrWhiteSpace(value) && value.Length >= 3)
        //        {
        //            _surname = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Olmaz!");
        //        }
        //    }
        //}
        //public string FullName
        //{
        //    get => Name + " " + Surname;
        //}
        //public byte Prop2 { set
        //    {
        //        _age = value;
        //    }
        //}
        //public string GetName() => _name;

        //public void SetName(string name)
        //{
        //    if (!String.IsNullOrWhiteSpace(name) && name.Length >= 3)
        //    {
        //        _name = name;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Olmaz!");
        //    }
        //}
        //public string GetSurname() => _surname;

        //public void SetSurname(string surname)
        //{
        //    if (!String.IsNullOrWhiteSpace(surname) && surname.Length >= 3)
        //    {
        //        _surname = surname;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Olmaz!");
        //    }
        //}
        //public byte GetAge() => _age;
        //public void SetAge(byte age)
        //{
        //    if (age <= 160)
        //    {
        //        _age = age;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Olmaz!");
        //    }
        //}

        //public string GetFullInfo()
        //{
        //    return Name + " " + GetSurname() + " " + GetAge();
        //}
    }
}
