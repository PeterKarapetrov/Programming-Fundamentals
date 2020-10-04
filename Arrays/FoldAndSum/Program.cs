using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().
                             Split(' ').
                             Select(int.Parse).
                             ToArray();

            int k = inputArr.Length / 4;
            int[] firstRowArr = new int[2 * k];
            
            for (int firstRowIndex = 0; firstRowIndex < inputArr.Length / 4; firstRowIndex++)
            {
                firstRowArr[firstRowIndex] = inputArr[k - 1];
                k--;
            }

            int endOfInputArrIndex = inputArr.Length - 1;
            k = inputArr.Length / 4;

            for (int firstRowIndex = k; firstRowIndex < 2 * k; firstRowIndex++)
            {
                firstRowArr[firstRowIndex] = inputArr[endOfInputArrIndex];
                endOfInputArrIndex--;
            }

            int[] sumArray = new int[2 * k];
            int inputArrIndex = k;

            for (int sumArrIndex = 0; sumArrIndex < 2 * k; sumArrIndex++)
            {
                sumArray[sumArrIndex] = firstRowArr[sumArrIndex] + inputArr[inputArrIndex];
                inputArrIndex++;
            }

            foreach (int sum in sumArray)
            {
                Console.Write($"{sum} ");
            }
            Console.WriteLine();
        }
    }
}
