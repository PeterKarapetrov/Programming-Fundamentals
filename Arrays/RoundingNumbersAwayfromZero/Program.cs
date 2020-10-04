using System;
using System.Linq;

namespace RoundingNumbersAwayfromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] doubleArray = Console.ReadLine()
                                   .Split()
                                   .Select(double.Parse)
                                   .ToArray();

            foreach (double num in doubleArray)
            {
                Console.WriteLine("{0} => {1}", num, Math.Round(num, MidpointRounding.AwayFromZero));
            }

        }
    }
}
