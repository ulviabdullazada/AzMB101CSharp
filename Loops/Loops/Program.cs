using System.Diagnostics.CodeAnalysis;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //int i = 1;
            //for (; i <= 5; i++)
            //{
            //    sum += i;
            //    //sum = sum + i;
            //}
            //Console.WriteLine(i);
            //Console.WriteLine(sum);
            //for (int i = 2345; i >= 0 ; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    //Console.WriteLine(i);
            //}
            //for (byte i = 10; i > 0; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //byte i = 1;
            //int sum = 0;
            //while (true) 
            //{
            //    //sum += i;
            //    i++;
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i <= 5; i++)
            //{
            //    sum += i;
            //    //sum = sum + i;
            //}
            //Console.WriteLine(sum);
            //int n = 20;
            //while (n < 10)
            //{
            //    n++;
            //    Console.WriteLine(n);
            //}

            //do
            //{
            //    n--;
            //    Console.WriteLine(n);
            //}
            //while (n > 10);
            //for (; ; )
            //{
            //    Console.WriteLine("asldkf");
            //}
            //int multiple = 1;
            //for(int i = 2; i <= 10; i ++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    multiple *= i;
            //}
            //Console.WriteLine(multiple);
            //for (int i = 0;true;)
            //{
            //    //if (i % 2 == 0) break;
            //    //if (i > 5) 
            //    //{ 
            //    //    break;
            //    //}
            //    Console.WriteLine(i);
            //    i++;
            //}
            //int multiple = 1;
            //for (int i = 0; i < 6; multiple*=i)
            //{
            //}
            int number1 = 4, number2 = 67, sum = 0;
            for (int i = number1; i <= number2; i++)
            {
                if (i % 12 == 0)
                {
                    sum++;
                    i += 11;
                }
            }
            Console.WriteLine(sum);
        }
    }
}