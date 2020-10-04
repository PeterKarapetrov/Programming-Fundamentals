using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int position = 0;
            int lenght = 1;
            int maxLenght = 1;

            for (int index = 0; index < listOfIntegers.Count - 1; index++)
            {
                if (listOfIntegers[index] == listOfIntegers[index + 1])
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                    continue;
                }

                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    position = index - (lenght - 2);
                }
            }

            if (maxLenght >= 1)
            {
                for (int index = position; index < position + maxLenght; index++)
                {
                    Console.Write($"{listOfIntegers[index]} ");
                }
            }
            Console.WriteLine();

        }
    }
}
