using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numList = Console.ReadLine()
                                    .Split()
                                    .Select(decimal.Parse)
                                    .ToList();

            for (int index = 0; index < numList.Count - 1; index++)
            {
                if (numList[index] == numList[index + 1])
                {
                    numList[index] = numList[index] + numList[index + 1];
                    numList.RemoveAt(index + 1);
                    index = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
