using System;
using System.Collections.Generic;

namespace PrimesInGivenRangeWithList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ulong> list = FindPrimesInRange(ulong.Parse(Console.ReadLine()), ulong.Parse(Console.ReadLine()));
            int count = list.Count;
            foreach (ulong item in list)
            {
                Console.Write($"{item}");
                
                if (count > 1)
                {
                    Console.Write(", ");
                    count--;
                }
            }
            Console.WriteLine();
        }

        private static List<ulong> FindPrimesInRange(ulong startIndex, ulong endIndex)
        {
            List<ulong> numList = new List<ulong>();

            for (ulong i = startIndex; i <= endIndex; i++)
            {
                bool numIsPrime = true;
                if (i == 0 || i == 1)
                {
                    numIsPrime = false;
                }
                for (ulong j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        numIsPrime = false; 
                    }
                }
                if (numIsPrime)
                {
                    numList.Add(i);
                }              
            }
            return numList;
        }
    }
}
