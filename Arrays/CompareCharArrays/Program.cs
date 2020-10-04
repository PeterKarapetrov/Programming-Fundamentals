using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstCharArray = Console.ReadLine().ToLower().Split(' ').Select(char.Parse).ToArray();
            char[] secondCharArray = Console.ReadLine().ToLower().Split(' ').Select(char.Parse).ToArray();
            int shorterArrayLenght = 0;

            if (firstCharArray.Length <= secondCharArray.Length)
            {
                shorterArrayLenght = firstCharArray.Length;
            }
            else
            {
                shorterArrayLenght = secondCharArray.Length;
            }

            bool firstArrayPrintFirst = false;

            for (int compareArrayIndex = 0; compareArrayIndex < shorterArrayLenght; compareArrayIndex++)
            {
                if (firstCharArray[compareArrayIndex] < secondCharArray[compareArrayIndex])
                {
                    firstArrayPrintFirst = true;
                    break;
                }
                else if (firstCharArray[compareArrayIndex] > secondCharArray[compareArrayIndex])
                {
                    firstArrayPrintFirst = false;
                    break;
                }

                if (compareArrayIndex == shorterArrayLenght - 1)
                {
                    if (firstCharArray.Length < secondCharArray.Length)
                    {
                        firstArrayPrintFirst = true;
                    }
                }
            }

            if (firstArrayPrintFirst)
            {
                foreach (char letter in firstCharArray)
                {
                    Console.Write($"{letter}");
                }
                Console.WriteLine();
                foreach (char letter in secondCharArray)
                {
                    Console.Write($"{letter}");
                }
            }
            else
            {
                foreach (char letter in secondCharArray)
                {
                    Console.Write($"{letter}");
                }
                Console.WriteLine();
                foreach (char letter in firstCharArray)
                {
                    Console.Write($"{letter}");
                }
            }
            Console.WriteLine();

        }
    }
}
