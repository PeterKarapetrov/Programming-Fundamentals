using System;
using System.Linq;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' '). Select(int.Parse).ToArray();
            int minNumberValue = int.MaxValue;
            int maxNumberValue = int.MinValue;
            int sumValue = 0;
            double elementAverageValue = 0;

            for (int index = 0; index < inputArray.Length; index++)
            {
                if (inputArray[index] >= maxNumberValue)
                {
                    maxNumberValue = inputArray[index];
                }

                if (inputArray[index] <= minNumberValue)
                {
                    minNumberValue = inputArray[index];
                }

                sumValue += inputArray[index];
            }

            elementAverageValue = 1.0 * sumValue / inputArray.Length;

            Console.WriteLine($"Min = {minNumberValue}");
            Console.WriteLine($"Max = {maxNumberValue}");
            Console.WriteLine($"Sum = {sumValue}");
            Console.WriteLine($"Average = {elementAverageValue}");
        }
    }
}
