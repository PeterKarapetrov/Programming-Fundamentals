using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrayLenght = inputArray.Length;
            int equalElementsMax = 1;
            int equalElementsCount = 1;
            int equalNum = int.MinValue;

            for (int arrayIndex = 0; arrayIndex < arrayLenght - 1; arrayIndex++)
            {
                if (inputArray[arrayIndex] == inputArray[arrayIndex + 1])
                {
                    equalElementsCount++;
                    if (equalElementsCount > equalElementsMax)
                    {
                        equalElementsMax = equalElementsCount;
                        equalNum = inputArray[arrayIndex];
                    }
                }
                else
                {
                    equalElementsCount = 1;
                }
            }

            for (int maxEqual = 1; maxEqual <= equalElementsMax; maxEqual++)
            {
                Console.Write($"{equalNum} ");
            }
            Console.WriteLine();
        }
    }
}
