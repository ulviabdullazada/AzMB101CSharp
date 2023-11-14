using FileStream.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FileStream
{
    internal class Program
    {
        public static string Root = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));

        static void Main(string[] args)
        {
            //string desktop = @"C:\Users\Birinci novbe\Desktop\AZMIU";
            //string file = "test.txt";
            //Directory.Delete(desktop);
            //if (!Directory.Exists(desktop))
            //{
            //    Directory.CreateDirectory(desktop);
            //}
            //if (File.Exists(Path.Combine(desktop, file)))
            //{
            //    File.Delete(Path.Combine(desktop, file));
            //}

            //File.Create(Path.Combine(desktop, file));
            //using (StreamWriter sw = new StreamWriter(Path.Combine(desktop, file), true))
            //{
            //    sw.WriteLine("Aleykum");
            //    sw.Close();
            //}
            //using (StreamReader sr = new StreamReader(Path.Combine(desktop, file)))
            //{
            //    Console.WriteLine(sr.ReadToEnd());
            //    sr.Close();
            //}
            //Student student = new Student
            //{
            //    Name = "Royal",
            //    Surname = " Asgarov"
            //};
            //ICollection<Student> students = new List<Student>();
            //students.Add(student);
            //students.Add(new Student { Name = "Vugar", Surname = "Samadov" });
            //var str = JsonConvert.SerializeObject(students);
            bool isContinued = true;
            do
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter surname");
                string surname = Console.ReadLine();
                if (AddStudent(new Student { Name = name, Surname = surname }))
                {
                    Console.WriteLine("Succeed");
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.WriteLine("Do you want to continue ? Y/N");
                isContinued = Console.ReadLine() == "Y";
            }
            while (isContinued);

        }
        static bool AddStudent(Student student)
        {
            List<Student> students = new List<Student>();
            using (StreamReader sr = new StreamReader(Path.Combine(Root, "students.json")))
            {
                string stds = sr.ReadToEnd();
                students = JsonConvert.DeserializeObject<List<Student>>(stds);
            }
            students.Add(student);

            using (StreamWriter sw = new StreamWriter(Path.Combine(Root, "students.json")))
            {
                string stds = JsonConvert.SerializeObject(students);
                sw.WriteLine(stds);
            }
            return true;
            //using (StreamWriter sw = new StreamWriter(Path.Combine(Root, "students.json"), true))
            //{
            //    try
            //    {
            //        sw.Write(str);
            //        return true;
            //    }
            //    catch (Exception)
            //    {
            //        return false;
            //    }
            //    finally
            //    {
            //        sw.Close();
            //    }
            //}
        }
    }
}