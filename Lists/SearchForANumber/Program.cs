using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().
                                    Split(' ').
                                    Select(int.Parse).
                                    ToList();

            int[] numbersArray = Console.ReadLine().
                                    Split(' ').
                                    Select(int.Parse).
                                    ToArray();

            int counter = 0;

            if (numbersArray[0] < inputList.Count && numbersArray[0] != 0)
            {
                for (int index = numbersArray[0]; inputList.Count - numbersArray[0] > counter;)
                {
                    inputList.RemoveAt(index);
                    counter++;
                }
            }
            
            counter = 1;

            if (numbersArray[1] <= inputList.Count)
            {
                for (int index = 0; counter <= numbersArray[1];)
                {
                    inputList.RemoveAt(index);
                    counter++;
                }
            }            

            if (inputList.Contains(numbersArray[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
