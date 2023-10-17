namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 12;
            //int filmLimitAge = 13;
            //if (age >= filmLimitAge)
            //{
            //    Console.WriteLine("Xosh izlemeler");
            //}
            //else
            //{
            //    Console.WriteLine("Olmaz!!!");
            //}
            //DRY - Dont Repeat Yourself
            //int side1 = 1;
            //int side2 = 2;
            //int side3 = 2;
            //if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            //{
            //    Console.WriteLine("Duzgun ucbucaqdir");
            //}
            //else
            //{
            //    Console.WriteLine("Ucbucaq duzgun deyil");
            //}
            //if (side1 + side2 <= side3)
            //{
            //    Console.WriteLine("Ucbucaq duzgun deyil");
            //}
            //else if (side1 + side3 <= side2)
            //{
            //    Console.WriteLine("Ucbucaq duzgun deyil");
            //}
            //else if (side2 + side3 <= side1)
            //{
            //    Console.WriteLine("Ucbucaq duzgun deyil");
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun ucbucaqdir");
            //}
            //int numberOfDays = 50;
            //if (numberOfDays == 30)
            //{
            //    Console.WriteLine("Aprel, Iyun, Sentyabr, Noyabr");
            //}
            //else if(numberOfDays == 31)
            //{
            //    Console.WriteLine("Yanvar,Mart, May, Iyul, Avqust, Oktyabr, Dekabr");
            //}
            //else if (numberOfDays > 27)
            //{
            //    Console.WriteLine("Fevral");
            //}
            //else
            //{
            //    Console.WriteLine("Error!");
            //}
            //int height = 177;
            //bool isMale = false;
            //if (height > 180)
            //{
            //    Console.WriteLine("arxa sira");
            //}
            //else if (height <= 180 && height > 170) 
            //{
            //    Console.WriteLine("orta sira");
            //}
            //else
            //{
            //    Console.WriteLine("on sira");
            //}
            //if (isMale)
            //{
            //    Console.WriteLine("sol teref");
            //}
            //else
            //{
            //    Console.WriteLine("sag teref");
            //}
            //int dayOfWeek = 7;
            //if (dayOfWeek == 1)
            //{
            //    Console.WriteLine("Monday");
            //}
            //else if (dayOfWeek == 2)
            //{
            //    Console.WriteLine("Tuesday");
            //}
            //else if (dayOfWeek == 3)
            //{
            //    Console.WriteLine("Wednesday");
            //}
            //else if (dayOfWeek == 4)
            //{
            //    Console.WriteLine("Thursday");
            //}
            //else if (dayOfWeek == 5)
            //{
            //    Console.WriteLine("Friday");
            //}
            //else if (dayOfWeek == 6)
            //{
            //    Console.WriteLine("Saturday");
            //}
            //else if (dayOfWeek == 7)
            //{
            //    Console.WriteLine("Sunday");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input");
            //}
            //switch (dayOfWeek)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //}
            //string season = "skdjfhasjkdfsh";
            //switch (season)
            //{
            //    case "Spring":
            //        Console.WriteLine("March, April, May");
            //        break;
            //    case "Summer":
            //        Console.WriteLine("June, July, August");
            //        break;
            //    case "Autmn":
            //        Console.WriteLine("September, October, November");
            //        break;
            //    case "Winter":
            //        Console.WriteLine("December, January, February");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong input");
            //        break;
            //}
            //int montOfYear = 4;
            //switch (montOfYear)
            //{
            //    case 1: case 2: case 12:
            //        Console.WriteLine("Winter");
            //        break;
            //    case 3:  case 4: case 5:
            //        Console.WriteLine("Spring");
            //        break;
            //    case 6: case 7: case 8:
            //        Console.WriteLine("Summer");
            //        break;
            //    case 9: case 10: case 11:
            //        Console.WriteLine("Autmn");
            //        break;
            //}


            //26 - beraber deyil
            //77 - beraberdir
            int number = 11;
            if (number > 9 && number < 100)
            {
                Console.WriteLine(number / 10 == number % 10);
                //if (number / 10 == number % 10)
                //{
                //    Console.WriteLine("Equals");
                //}
                //else
                //{
                //    Console.WriteLine("Not equals");
                //}
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}