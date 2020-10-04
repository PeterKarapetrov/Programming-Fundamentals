using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeekArray = { "Invalid day", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int numDay = int.Parse(Console.ReadLine());

            switch (numDay)
            {
                case 1:
                    Console.WriteLine(dayOfWeekArray[1]);
                    break;
                case 2:
                    Console.WriteLine(dayOfWeekArray[2]);
                    break;
                case 3:
                    Console.WriteLine(dayOfWeekArray[3]);
                    break;
                case 4:
                    Console.WriteLine(dayOfWeekArray[4]);
                    break;
                case 5:
                    Console.WriteLine(dayOfWeekArray[5]);
                    break;
                case 6:
                    Console.WriteLine(dayOfWeekArray[6]);
                    break;
                case 7:
                    Console.WriteLine(dayOfWeekArray[7]);
                    break;
                default:
                    Console.WriteLine(dayOfWeekArray[0]);
                    break;
            }
        }
    }
}
