using System.Collections;
using System.Globalization;

namespace GenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListObject objs = 
            //    new ListObject(1,2,new ListInt(),3,4,5,true, false, "Salam");
            //objs.Add(10);
            //Console.WriteLine(objs.Contains(false));
            //CustomList<int> nums = new CustomList<int>(10,20,30,40);
            //nums.Add(1);
            //nums.Add(2);
            //Console.WriteLine(nums[4]);
            //CustomList<string> strs = new CustomList<string>("1","2");
            //CustomList<Person> people = new CustomList<Person>(new Person { Name = "Inara", Surname = "Ismayilova"});
            //people.Add(new Person { Name = "Jafar", Surname = "Mustafazada" });
            //people.Add(new Person { Name = "Malak", Surname = "Azizova" });
            //for (int i = 0;i<3; i++)
            //{
            //    Console.WriteLine(people[i].Name + " " + people[i].Surname);
            //}
            //CustomList<int> nums = new CustomList<int>();
            //nums.Add(10);
            //nums.Add(10);
            //nums.Add(10);
            //nums.Add(10);
            //nums.Add(10);
            //nums.Add(10);
            //nums.Add(10);
            //nums.Add(10);
            //nums.Add(10);
            //nums.Add(10);
            //SortedList<string, int> list = new SortedList<string, int>();
            //list.Add("a", 111);
            //Console.WriteLine(list["a"]);
            //Console.BackgroundColor = ConsoleColor.White;
            //Stack<int> stack = new Stack<int>();
            //Console.ForegroundColor = ConsoleColor.Blue;
            //stack.Push(42);
            //stack.Push(41);
            //stack.Push(40);
            //stack.Push(39);
            //stack.Push(38);
            //stack.Push(37);
            //foreach (int i in stack) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(stack.Pop());
            //Console.ForegroundColor = ConsoleColor.Green;
            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("-----------------------------------");
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //LinkedList<int> ll = new LinkedList<int>();
            //ll.AddFirst(1);
            //ll.AddFirst(2);
            //foreach (var item in ll)
            //{
            //    Console.WriteLine(item);
            //}
            //Dictionary<string, string> dctrny = new Dictionary<string, string>();
            //dctrny.Add("123", "aksdfjhasdf");
            HashSet<int> set = new HashSet<int>();
            Console.WriteLine(set.Add(1));
            Console.WriteLine(set.Add(1));
            Console.WriteLine(set.Add(1));
            //Hashtable ht = new Hashtable(); 
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person()
        {
            
        }
    }
}