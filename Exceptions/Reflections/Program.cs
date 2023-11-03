using Reflections;
using System.Reflection;

//Console.WriteLine();

//t.GetProperty("CreatedOn")
//    .SetValue(obj, new DateTime(2009, 10, 14), null);

//Student s = new Student();
//var field = s.GetType().GetField("KesrSayi", System.Reflection.BindingFlags.NonPublic
//    | System.Reflection.BindingFlags.Instance);
//field.SetValue(s, 0);
//Console.WriteLine(field.GetValue(s));
var fields = typeof(Student).GetFields(BindingFlags.NonPublic |
                         BindingFlags.Instance);
foreach (var field in fields)
    Console.WriteLine(field);
//foreach (var prop in )
//{
//    Console.WriteLine(prop);
//}