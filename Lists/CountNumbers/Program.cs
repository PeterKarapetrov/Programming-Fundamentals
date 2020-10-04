using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<int> numCounts = new List<int>();

            numList.Sort();
            int counter = 0;

            for (int index = 0; index < numList.Count; index++)
            {
                for (int i = index; i < numList.Count; i++)
                {
                    if (numList[index] == numList[i])
                    {
                        counter++;
                    }
                }
                numCounts.Add(counter);
                counter = 0;
            }

            Console.WriteLine("{0} -> {1}", numList[0], numCounts[0]);
            for (int index = 1; index < numList.Count; index++)
            {
                if (numList[index] != numList[index - 1])
                {
                    Console.WriteLine("{0} -> {1}", numList[index], numCounts[index]);
                }
            }

        }
    }
}
