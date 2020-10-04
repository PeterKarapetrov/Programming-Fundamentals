using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrayLenght = inputArray.Length;
            int increasingElementsMax = 1;
            int increasingElementsCount = 1;
            int position = int.MinValue;

            for (int arrayIndex = 0; arrayIndex < arrayLenght - 1; arrayIndex++)
            {
                if (inputArray[arrayIndex + 1] > inputArray[arrayIndex])
                {
                    increasingElementsCount++;
                    if (increasingElementsCount > increasingElementsMax)
                    {
                        increasingElementsMax = increasingElementsCount;
                        position = arrayIndex + 1;
                    }
                }
                else
                {
                    increasingElementsCount = 1;
                }
            }

            int startNumPosition = position - increasingElementsMax + 1;

            if (startNumPosition >= 0)
            {
                for (int sequenceStart = 1; sequenceStart <= increasingElementsMax; sequenceStart++)
                {
                    Console.Write($"{inputArray[startNumPosition]} ");
                    startNumPosition++;
                }
                Console.WriteLine();
            }
        }
    }
}
