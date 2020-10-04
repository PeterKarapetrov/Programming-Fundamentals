using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] inputArray = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int[] resultArray = new int[inputArray.Length];

            for (int index = 0; index < inputArray.Length; index++)
            {
                for (int resIndex = index; resIndex < inputArray.Length; resIndex++)
                {
                    if (inputArray[index] == inputArray[resIndex])
                    {
                        resultArray[index]++;
                    }
                }
            }
            int result = int.MinValue;
            int resultIndex = int.MinValue;

            for (int i = 0; i < resultArray.Length; i++)
            {
                if (resultArray[i] > result)
                {
                    result = resultArray[i];
                    resultIndex = i;
                }
            }

            Console.WriteLine(inputArray[resultIndex]);
        }
    }
}
