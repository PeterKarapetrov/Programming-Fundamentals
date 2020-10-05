using System;
using System.Collections.Generic;
using System.Globalization;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

            DateTime[] holidaysInBG = new DateTime[11];
            holidaysInBG[0] = DateTime.ParseExact("01-01", "dd-MM", CultureInfo.InvariantCulture);
            holidaysInBG[1] = DateTime.ParseExact("03-03", "dd-MM", CultureInfo.InvariantCulture);
            holidaysInBG[2] = DateTime.ParseExact("01-05", "dd-MM", CultureInfo.InvariantCulture);
            holidaysInBG[3] = DateTime.ParseExact("06-05", "dd-MM", CultureInfo.InvariantCulture);
            holidaysInBG[4] = DateTime.ParseExact("24-05", "dd-MM", CultureInfo.InvariantCulture);
            holidaysInBG[5] = DateTime.ParseExact("06-09", "dd-MM", CultureInfo.InvariantCulture);
            holidaysInBG[6] = DateTime.ParseExact("22-09", "dd-MM", CultureInfo.InvariantCulture);
            holidaysInBG[7] = DateTime.ParseExact("01-11", "dd-MM", CultureInfo.InvariantCulture);
            holidaysInBG[8] = DateTime.ParseExact("24-12", "dd-MM", CultureInfo.InvariantCulture);
            holidaysInBG[9] = DateTime.ParseExact("25-12", "dd-MM", CultureInfo.InvariantCulture);
            holidaysInBG[10] = DateTime.ParseExact("26-12", "dd-MM", CultureInfo.InvariantCulture);

            int workingDayscounter = 0;
            bool isHoliday = false;

            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                {
                    isHoliday = true;
                }

                for (int i = 0; i < holidaysInBG.Length; i++)
                {
                    if (day.Month == holidaysInBG[i].Month && day.Day == holidaysInBG[i].Day)
                    {
                        isHoliday = true;
                    }
                }

                if (!isHoliday)
                {
                    workingDayscounter++;
                }
                isHoliday = false;
            }

            Console.WriteLine(workingDayscounter);
        }
    }
}
