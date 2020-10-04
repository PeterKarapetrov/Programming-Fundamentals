using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            List<int> resultList = new List<int>();

            foreach (int num in numList)
            {
                if (num % Math.Sqrt(num) == 0)
                {
                    resultList.Add(num);
                }
            }

            resultList.Sort();
            resultList.Reverse();
            Console.WriteLine(string.Join(" ", resultList));

        }
    }
}
