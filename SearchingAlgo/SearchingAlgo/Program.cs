namespace SearchingAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Linear
            //int[] nums = { 14, 21, 7, 86, 2, 16, 9 };
            //bool contains = false;
            //int number = 9;
            //int foundedIndex = -1;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] == number)
            //    {
            //        //contains = true;
            //        //Console.WriteLine(i);
            //        foundedIndex = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(foundedIndex);
            //if (contains == false)
            //{
            //    Console.WriteLine(-1);
            //}
            #endregion
            int[] nums = { 9, 11, 13, 49, 55, 67, 81, 90, 93, 97 };
            int number = 1;
            int leftI = 0, rightI = nums.Length - 1;
            int cin = (leftI + rightI) / 2;
            int foundedIndex = -1;
            while (leftI <= rightI) 
            {
                if (nums[cin] == number)
                {
                    foundedIndex = cin;
                    break;
                }
                else if (nums[cin] < number)
                {
                    leftI = cin + 1;
                }
                else
                {
                    rightI = cin - 1;
                }
                cin = (leftI + rightI) / 2;
            }
            Console.WriteLine(foundedIndex);
        }
    }
}