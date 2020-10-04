using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool thereIsEqualSums = false;

            for (int arrayIndex = 0; arrayIndex < inputArray.Length; arrayIndex++)
            {
                for (int leftSumIndexes = 0; leftSumIndexes < arrayIndex; leftSumIndexes++)
                {
                    leftSum += inputArray[leftSumIndexes];
                }

                for (int rightSumIndexes = arrayIndex + 1; rightSumIndexes < inputArray.Length; rightSumIndexes++)
                {
                    rightSum += inputArray[rightSumIndexes];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(arrayIndex);
                    thereIsEqualSums = true;
                    break;
                }
                leftSum = 0;
                rightSum = 0;

            }

            if (!thereIsEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
