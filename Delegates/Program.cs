using System.Threading.Channels;
using System.Xml.Schema;

namespace Delegates
{
    delegate bool CheckNumber(int num);
    //delegate bool Check<T>(T val);
    //delegate bool CheckString(string val);
    delegate void Print(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 6 };

            List<int> list = new List<int>(nums);
            list.Add(123);
            list.Add(12);
            list.Add(99);
            list.Add(127);
            list.Add(12);
            //list.FindAll(num => true);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            Console.WriteLine(list.RemoveAll(num => num > 12));
            Console.WriteLine("----------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(list.FirstOrDefault(x=> x == 21));


            //Console.WriteLine(list.Any(num => num < 2));

            //Print funcs = PrintLower;
            //funcs += PrintCaptalize;
            //funcs += delegate (string str){
            //  Console.WriteLine(str.ToLower().Substring(0, str.Length-1) + Char.ToUpper(str[^1]));
            //}
            //funcs += str => Console.WriteLine(str.ToLower().Substring(0, str.Length-1) + Char.ToUpper(str[^1]));
            //funcs("rashad");
            //funcs -= PrintCaptalize;
            //funcs("laMAN");
            //CheckNumber func = IsEven;
            //Console.WriteLine(func(27));
            //Console.WriteLine(Sum(nums, IsEven));
            //Console.WriteLine(Sum(nums, IsOdd));
            //Test t = new Test();
            //Console.WriteLine(Sum(nums, x => x % 3 == 0));
            //Action<int, int> actions = (num, percent) => Console.WriteLine(num * percent / 100f);
            //actions += Test.TestS;
            //actions += t.TestNS;
            //actions(7, 5);
        }

        static int Sum(int[] arr, Predicate<int> method)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                if (method(item))
                {
                    sum += item;
                }
            }
            return sum;
        }
        static bool IsDivide3(int num) => num % 3 == 0;
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
        static int SumEven(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
        static int SumOdd(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                if (item % 2 == 1)
                {
                    sum += item;
                }
            }
            return sum;
        }
        static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        static void PrintLower(string name)
        {
            Console.WriteLine(name.ToLower());
        }
        static void PrintCaptalize(string str)
        {
            Console.WriteLine(Char.ToUpper(str[0]) + str.Substring(1).ToLower());
        }
    }
    class Test
    {
        public void TestNS(int num, int num2)
        {
            Console.WriteLine(num + num2);
        }
        public static void TestS(int num, int num2) 
        {
            Console.WriteLine(num * num2);
        }
    }
}