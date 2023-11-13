using System.Diagnostics;

namespace Paralellism
{
    internal class Program
    {
        static int eded = 0;
        static object lockObject =new object();
        static bool isStop = false;
        static void Main(string[] args)
        {
            #region Thread
            //Loop1();
            //Stopwatch sw = Stopwatch.StartNew();
            //Thread t1 = new Thread(Loop1);
            //Thread t2 = new Thread(Loop2);
            //t1.Start();
            //t2.Start();
            //t2.Join();
            //t1.Join();
            //Console.WriteLine("----------->" + sw.ElapsedMilliseconds);
            #endregion
            #region Race condition
            //Increase();
            //Decrease();
            //Thread t1 = new Thread(Increase);
            //Thread t2 = new Thread(Decrease);
            //t1.Start();
            //t2.Start();
            //t1.Join();
            //t2.Join();
            //race condition
            //Console.WriteLine(eded);
            #endregion
            #region Task
            //IncreaseAsync().Wait();
            //DecreaseAsync().Wait();
            //Task.WhenAll(decr, incr).When();
            Task.WhenAll(Task.Run(() =>
            {
                for (int i = 0; i < 500; i++)
                {
                    Console.WriteLine(i);
                }
            }), Task.Run(() =>
            {
                for (int i = 500; i < 1000; i++)
                {
                    Console.WriteLine(i);
                }
            }));
            //Console.WriteLine(eded);
            #endregion
        }
        #region Thread
        static void Loop1()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Loop2()
        {
            for (int i = 500; i < 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        #endregion
        #region Race condition
        static void Increase()
        {
            for(int i = 0;i < 500000;i++)
            {
                //lock(lockObject)
                //{
                //    eded++;
                //}
                eded++;
            }
        }
        static void Decrease()
        {
            for (int i = 0; i < 500000; i++)
            {
                //lock (lockObject)
                //{
                //    eded--;
                //}
                eded--;
            }
        }
        #endregion
        #region Task
        static async Task IncreaseAsync()
        {
            await Task.Run(Increase);
        }
        static async Task DecreaseAsync()
        {
            await Task.Run(Decrease);
        }
        #endregion
    }
}