using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbersArray = Console.ReadLine()
                                 .Split()
                                 .Select(double.Parse)
                                 .ToArray();

            var numOccurances = new SortedDictionary<double, int>();


            foreach (double num in numbersArray)
            {
                if (numOccurances.ContainsKey(num))
                {
                    numOccurances[num]++;
                }
                else
                {
                    numOccurances[num] = 1;
                }
            }

            foreach (double key in numOccurances.Keys)
            {
                Console.WriteLine($"{key} -> {numOccurances[key]}");
            }    
        }
    }
}
