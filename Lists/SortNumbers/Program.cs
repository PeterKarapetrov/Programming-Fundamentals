using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numList = Console.ReadLine()
                                .Split()
                                .Select(decimal.Parse)
                                .ToList();

            numList.Sort();
            Console.WriteLine(string.Join(" <= ", numList));
        }
    }
}
