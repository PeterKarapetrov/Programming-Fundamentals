using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().
                                     Split().
                                     Select(int.Parse).
                                     ToList();

            long sum = 0;

            foreach (int number in inputList)
            {
                int reverseNum = 0;
                int lastNum = 0;
                int newNum = number;
                while (newNum != 0)
                {
                    lastNum = newNum % 10;
                    newNum = newNum / 10;
                    reverseNum = reverseNum * 10 + lastNum;
                }
                sum += reverseNum;
            }

            Console.WriteLine(sum);
        }
    }
}
