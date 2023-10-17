namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5 };
            //int[] nums = new int[5];
            //int a = 21;
            //nums[0] = 2;
            //nums[1] = a;
            //nums[2] = 9;
            //nums[3] = 19;
            //for(int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            int[] nums = { 2, -3, 21, 5, 76, 15 };
            //1.
            //for (int i = 0; i < nums.Length; i+=2)
            //{
            //    //if (i % 2 == 0)
            //    //{
            //    //    Console.WriteLine(nums[i]);
            //    //}
            //    Console.WriteLine(nums[i]);
            //}

            //2. 
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}

            //3.
            //int count = 0;
            //for (int i = 0; i < nums.Length; i++) 
            //{
            //    if (nums[i] % 5 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //4.
            //int maxNumber = int.MinValue;
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if(maxNumber < nums[i])
            //    {
            //        maxNumber = nums[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //1.
            int count = 0;
            bool isPrime = true;
            int ramazan = 0, adil = 0, rusif = 0, ulvi = 0;
            int num = 103;
            for (int i = 1; i <= num; i++)
            {
                ramazan += 4;
                if (num % i == 0)
                {
                    count++;
                }
                if (count == 3) 
                {
                    break;
                }
            }
            int halfOfNum = num/2;
            for (int i = 2; i <= halfOfNum; i++)
            {
                adil += 3;
                if (num % i == 0) 
                { 
                    isPrime = false;
                    break;
                }
            }
            
            for (int i = 3; i < num/3; i+=2)
            {
                rusif += 3;
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            rusif++;
            if (num % 2 == 0)
            {
                Console.WriteLine("Murekkebdir");
            }
            else
            {
                switch (num)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("Ne sade ne murekkeb");
                        break;
                    case 2:
                    case 3:
                        Console.WriteLine("Sadedir");
                        break;
                    default:
                        Console.WriteLine("Sadedir");
                        break;
                }
                rusif++;
            }

            ulvi++;
            if (num % 2 != 0) 
            {
                for (int i = 3; i*i <= num; i+=2)
                {
                    ulvi += 3;
                    if (num % i == 0)
                    {
                        isPrime = true;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }
            Console.WriteLine("Ramazan step count : " + ramazan);
            Console.WriteLine("Adil step count : " + adil);
            Console.WriteLine("Rusif step count : " + rusif);
            Console.WriteLine("Ulvi step count : " + ulvi);

        }
    }
}