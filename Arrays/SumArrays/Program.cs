using System;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumArray = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();

            int[] secondNumArray = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();

            int biggerLenght = Math.Max(firstNumArray.Length, secondNumArray.Length);
            bool firstArrayIsLonger = false;

            if (firstNumArray.Length - secondNumArray.Length >= 0)
            {
                firstArrayIsLonger = true;
            }

            for (int index = 0; index < biggerLenght; index++)
            {
                if (firstArrayIsLonger)
                {
                    if (index <= secondNumArray.Length - 1)
                    {
                        firstNumArray[index] = firstNumArray[index] + secondNumArray[index];
                    }
                    else
                    {
                        int shorterArrayIndex = index % secondNumArray.Length;
                        firstNumArray[index] = firstNumArray[index] + secondNumArray[shorterArrayIndex];
                    }
                }
                else
                {
                    if (index <= firstNumArray.Length - 1)
                    {
                        secondNumArray[index] = firstNumArray[index] + secondNumArray[index];
                    }
                    else
                    {
                        int shorterArrayIndex = index % firstNumArray.Length;
                        secondNumArray[index] = secondNumArray[index] + firstNumArray[shorterArrayIndex];
                    }
                }
            }

            if (firstArrayIsLonger)
            {
                Console.WriteLine(string.Join(" ", firstNumArray));
            }
            else
            {
                Console.WriteLine(string.Join(" ", secondNumArray));
            }
        }
    }
}
