namespace Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetElementById(null);

            //Car car = new Car
            //{
            //    Brand = "Zapi",
            //    Model = "c500",
            //    FuelType = FuelTypes.Dizel
            //};
            //Console.WriteLine(car.Brand + " " + car.Model + " " + car.FuelType);
            foreach (var s in Enum.GetValues(typeof(FuelTypes))) 
            {
                Console.WriteLine(Convert.ToInt32(s) + " " + s);
            }
            
            //switch (car.FuelType) 
            //{
            //    case FuelTypes.Elektrik:
            //        break;
            //    case FuelTypes.Qaz:
            //        break;
            //}
            //Console.WriteLine(FuelTypes.Qaz == FuelTypes.Elektrik);
        }
        public static void GetElementById(int? id)
        {
            if (id == null)
            {
                Console.WriteLine("Id null ola bilmez");
            }
            else
            {
                Console.WriteLine("element found");
            }
        }
    }
}