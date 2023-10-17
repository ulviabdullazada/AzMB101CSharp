namespace Methods
{
    internal class Program
    {
        //static void SayHi()
        //{
        //    Console.WriteLine("Salam");
        //}
        static void Main(string[] args)
        {
            //SayHi();
            //int salary = 1400;
            //int bonus = salary * 20 / 100;
            //Console.WriteLine(bonus);

            //int num1 = 25;
            //float num2 = 30;
            //float result = num1 * num2 / 100;
            //Console.WriteLine(result);
            //CalcPercentage(1400, 20);
            //CalcPercentage(25, 30);
            //CalcPercentage(
            //    percent: 40, 
            //    number: 100
            //    );
            //CalcPercentage(123);
            //CalcPercentage(number:300);
            //CalcPercentageVoid(40,40);
            //float result = CalcPercentage(40, 40);
            //Console.WriteLine(result);
            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(Sum(arr));
            //Console.WriteLine(Sum(new int[] {1,2,3,4,5,6,7}));
            //Console.WriteLine(Sum(new string[] {"Ali", "Vali"},1,2,3,4,6,9));
            //Test();
            //string name = "Royal";
            //string surname = "Asgarov";
            //int age = 21;
            //Console.WriteLine(Info(name));
            //Console.WriteLine(Info(name, surname));
            //Console.WriteLine(Info(name, surname, age));

            A(new int[] {1,2,3,4,5});
        }


        
        static void A(int num1, int num2 = 10)
        {
            Console.WriteLine("Cut parametr");
        }
        static void A(params int[] nums)
        {
            Console.WriteLine("Params");
        }
        //static void CalcPercentageVoid(float number, float percent = 100)
        //{
        //    return;
        //    Console.WriteLine("Void : " + number * percent / 100);
        //}
        //static dynamic CalcPercentage(float number, float percent)
        //{
        //    return number*percent/100;
        //}
        //static int Sum(string[] num1, params int[] nums)
        //{
        //    int result = 0;
        //    foreach (var num in nums)
        //    {
        //        result += num;
        //    }
        //    return result;
        //}
        //method signature - name, argument type, argument count
        //static void Test(int a)
        //{
        //    Console.WriteLine("asd");
        //}
        //static void Test()
        //{
        //    Console.WriteLine("dsa");
        //}
        //static string Info(string name)
        //{
        //    return name;
        //}
        //static string Info(string name, string surname)
        //{
        //    return surname[0] + ". " + name;
        //}
        //static string Info(string name, string surname, int age)
        //{
        //    return Info(name, surname) + " - " + age;
        //}
    }

}