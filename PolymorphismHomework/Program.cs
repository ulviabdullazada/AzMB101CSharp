using Core.Interfaces;
using Core.Models;
using Service.Services;

namespace PolymorphismHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleService service = new VehicleService();
            int input; 
            do
            {
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CaFuad:
                        if (service.AddCar(CreateCar()) == false)
                        {
                            Console.WriteLine("Sehv yazdin");
                            goto CaFuad;
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        for (int i = 0; i< service._arr.Length; i++)
                        {
                            Console.WriteLine(i + ". " + service._arr[i]);
                        }
                        break;
                    case 5:
                        service.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                        break;
                }
            } while (input > 0 && input < 6);
        }
        public static Car CreateCar()
        {
            Car car = new Car
            {
                CurrentOil = Convert.ToSingle(Console.ReadLine()),
                DoorCount = Convert.ToByte(Console.ReadLine()),
                DriveTime = Convert.ToSingle(Console.ReadLine()),
                DrivePath = Convert.ToSingle(Console.ReadLine()),
                WinCode = Console.ReadLine()
            };
            return car;
        }
    }

}