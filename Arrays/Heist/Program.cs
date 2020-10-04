using System;
using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine()
                           .Split()
                           .Select(int.Parse)
                           .ToArray();

            string[] heist = Console.ReadLine()
                             .Split()
                             .ToArray();

            long totalEarnings = 0L;
            long totalExpenses = 0L;

            while (heist[0] != "Jail" && heist[1] != "Time")
            {
                totalEarnings += GetEarnings(heist[0], prices[0], prices[1]);
                totalExpenses += int.Parse(heist[1]);

                heist = Console.ReadLine()
                        .Split()
                        .ToArray();
            }

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", totalEarnings - totalExpenses);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", totalExpenses - totalEarnings);
            }
        }

        static long GetEarnings(string heistText, int jewelsPrice, int goldPrice)
        {
            long heistEarnings = 0L;

            foreach (char letter in heistText)
            {
                if (letter == '%')
                {
                    heistEarnings += jewelsPrice;
                }
                else if (letter == '$')
                {
                    heistEarnings += goldPrice;
                }
            }
            
            return heistEarnings;
        }
    }
}
