using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            numList.RemoveAll(num => num < 0);
            numList.Reverse();

            if (numList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numList));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
