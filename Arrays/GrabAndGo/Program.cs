using System;
using System.Linq;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numList = Console.ReadLine()
                            .Split()
                            .Select(long.Parse)
                            .ToArray();

            int number = int.Parse(Console.ReadLine());

            int biggestIndex = 0;

            for (int index = 0; index < numList.Length; index++)
            {
                if (numList[index] == number)
                {
                    biggestIndex = index;
                }
            }

            if (biggestIndex == 0 && numList.Length != 1)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else if (biggestIndex == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numList.Take(biggestIndex).ToArray().Sum());
            }   
        }
    }
}
