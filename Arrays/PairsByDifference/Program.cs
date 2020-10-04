using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int compareNumIndex = 0; compareNumIndex < inputArray.Length; compareNumIndex++)
            {
                for (int comparedWithNumIndex = compareNumIndex + 1; comparedWithNumIndex < inputArray.Length; comparedWithNumIndex++)
                {
                    if (Math.Abs(inputArray[compareNumIndex] - inputArray[comparedWithNumIndex]) == difference)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
