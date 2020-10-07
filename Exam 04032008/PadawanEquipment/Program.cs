using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());
            decimal totalBill = 0M;
            int freeOfChargeBelts = 0;

            if (studentsCount > 5)
            {
                freeOfChargeBelts = studentsCount / 6;
            }

            totalBill = (lightsaberPrice * (decimal)Math.Ceiling(studentsCount * 1.10)) + (robePrice * studentsCount) + beltPrice * (studentsCount - freeOfChargeBelts);
            if (budget >= totalBill)
            {
                Console.WriteLine($"The money is enough - it would cost {totalBill:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalBill - budget}lv more.");
            }

        }
    }
}
