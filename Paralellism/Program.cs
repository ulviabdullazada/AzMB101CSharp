using System.Diagnostics;

namespace Paralellism
{
    internal class Program
    {
        static int eded = 0;
        static object lockObject =new object();
        static bool isStop = false;
        static readonly IEnumerable<string> links = new string[]
        {
            "https://docs.microsoft.com",
            "https://docs.microsoft.com/aspnet/core",
            "https://docs.microsoft.com/azure",
            "https://docs.microsoft.com/azure/devops",
            "https://docs.microsoft.com/dotnet",
            "https://docs.microsoft.com/dynamics365",
            "https://docs.microsoft.com/education",
            "https://docs.microsoft.com/enterprise-mobility-security",
            "https://docs.microsoft.com/gaming",
            "https://docs.microsoft.com/graph",
            "https://docs.microsoft.com/microsoft-365",
            "https://docs.microsoft.com/office",
            "https://docs.microsoft.com/powershell"
        };

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
            //Task.WhenAll(Task.Run(() =>
            //{
            //    for (int i = 0; i < 500; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}), Task.Run(() =>
            //{
            //    for (int i = 500; i < 1000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}));
            //Console.WriteLine(eded);
            #endregion
            #region CPU Bound
            //Stopwatch sw = Stopwatch.StartNew();
            ////SeherYemeyi();
            //SeherYemeyiAsync().Wait();
            //Console.WriteLine("Yemek " + (float)sw.ElapsedMilliseconds / 1000f + " deqiqe hazirlandi");
            #endregion
            #region IO Bound
            Stopwatch sw = Stopwatch.StartNew();
            GetData();
            Console.WriteLine(sw.ElapsedMilliseconds + " non async");
            sw.Restart();
            GetDataAsync().Wait();
            Console.WriteLine(sw.ElapsedMilliseconds + " async");
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
        #region CPU Bound
        static void SeherYemeyi()
        {
            Yumurta();
            Caydan();
            Sufre();
        }
        static void Yumurta()
        {
            Console.WriteLine("Qaz yandirildi");
            Console.WriteLine("Tava qizdirilir");
            Console.WriteLine("Yumurta qirilir");
            Console.WriteLine("Yumurta qarisdirilir");
            Console.WriteLine("Yumurta bishir");
            Thread.Sleep(5000);
            Console.WriteLine("Yumurta bishdi");
        }
        static void Caydan()
        {
            Console.WriteLine("Qaz yandirildi");
            Console.WriteLine("Caydana su dolduruldu");
            Console.WriteLine("Caydan qaynamaga qoyuldu");
            Thread.Sleep(8000);
            Console.WriteLine("Cay qaynadi");
        }
        static void Sufre()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Sufre hazirdir");
        }
        static async Task SeherYemeyiAsync()
        {
            //await YumurtaAsync();
            //await CaydanAsync();
            //await SufreAsync();
            await Task.WhenAll( CaydanAsync(), YumurtaAsync(), SufreAsync());
            await Task.Run(() =>
            {
                Console.WriteLine("Nush olsun");
            });
        }
        static async Task YumurtaAsync()
        {
            Console.WriteLine("Qaz yandirildi");
            Console.WriteLine("Tava qizdirilir");
            Console.WriteLine("Yumurta qirilir");
            Console.WriteLine("Yumurta qarisdirilir");
            Console.WriteLine("Yumurta bishir");
            await Task.Delay(5000);
            Console.WriteLine("Yumurta bishdi");
        }
        static async Task CaydanAsync()
        {
            Console.WriteLine("Qaz yandirildi");
            Console.WriteLine("Caydana su dolduruldu");
            Console.WriteLine("Caydan qaynamaga qoyuldu");
            await Task.Delay(8000);
            Console.WriteLine("Cay qaynadi");
        }
        static async Task SufreAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Sufre hazirdir");
        }
        #endregion
        #region IO Bound
        static void GetData()
        {
            HttpClient client = new HttpClient();
            foreach (var link in links)
            {
                Console.WriteLine(client.GetStringAsync(link).Result.Length);
            }
        }
        static async Task GetDataAsync()
        {
            HttpClient client = new HttpClient();
            ICollection<Task<string>> tasks = new List<Task<string>>();
            foreach (var link in links)
            {
                //await client.GetStringAsync(link);
                tasks.Add(client.GetStringAsync(link));
            }
            await Task.WhenAll(tasks);
        }
        #endregion
    }
}