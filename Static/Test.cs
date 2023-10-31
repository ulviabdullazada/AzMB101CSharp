namespace AzMIU
{
    internal class Test
    {
        
        public Test()
        {
            Console.WriteLine("Non-static ctor");
        }
        static Test()
        {
            Console.WriteLine("Static ctor");
        }

        public string Aleykum { get; set; }
        public static string Salam { get; set; }
        void B()
        {
            Aleykum = "123";
            Salam = "123";
        }
    }
}
