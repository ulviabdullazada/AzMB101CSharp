namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int vuqar = 5; // in stack
            //int meftune = vuqar; // in stack
            //meftune++;
            //Console.WriteLine(vuqar);
            //Console.WriteLine(meftune);
            //int[] ramazan = { 1, 2, 3, 4 }; // heap  0x001
            //int[] royal = { 1, 2, 3, 4 }; // heap 0x001123
            //royal[0] = 10;
            //foreach (int pendir in royal)
            //{
            //    Console.WriteLine("Royal " + pendir);
            //}
            //foreach (int pendir in ramazan)
            //{
            //    Console.WriteLine("Ramazan " + pendir);
            //}
            int[] arr = { 1, 5, 8, 11, 16, -4, 7, -8, 9, 22 };
            SwapMinAndMax(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static int MinIndex(int[] array)
        {
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            return min;
        }
        static int MaxIndex(int[] array)
        {
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            return max;
        }
        // a = 5
        // b = 8
        // a = a + b = 5 + 8 = 13
        // b = a - b = 13 - 8 = 5
        // a = a - b = 13 - 5 = 8
        static void SwapMinAndMax(int[] array)
        {
            int minI = MinIndex(array); 
            int maxI = MaxIndex(array);

            //minI = maxI + minI;
            //maxI = minI - maxI;
            //minI = minI - maxI;
            int temp = array[minI];
            array[minI] = array[maxI];
            array[maxI] = temp;


            //array[minI] = array[maxI] + array[minI];
            //array[maxI] = array[minI] - array[maxI];
            //array[minI] = array[minI] - array[maxI];
        }
    }
}