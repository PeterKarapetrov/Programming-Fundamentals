using System;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArrayOfWords = Console.ReadLine().Split(' ');
            string[] secondArrayOfWords = Console.ReadLine().Split(' ');
            int shorterArrayLenght = 0;

            if (firstArrayOfWords.Length <= secondArrayOfWords.Length)
            {
                shorterArrayLenght = firstArrayOfWords.Length;
            }
            else
            {
                shorterArrayLenght = secondArrayOfWords.Length;
            }

            bool hasLeftCommonEnd = false;
            int numOFCommonWordsInTheLeft = 0;

            for (int arrayElementPosition = 0; arrayElementPosition < shorterArrayLenght; arrayElementPosition++)
            {
                
                if (firstArrayOfWords[arrayElementPosition] == secondArrayOfWords[arrayElementPosition])
                {
                    hasLeftCommonEnd = true;
                    numOFCommonWordsInTheLeft++;
                }
            }

            bool hasRightCommonEnd = false;
            int numOFCommonWordsInTheRight = 0;


            for (int arrayElementsPositionInReverse = 0; arrayElementsPositionInReverse < shorterArrayLenght ; arrayElementsPositionInReverse++)
            {
                if (firstArrayOfWords[firstArrayOfWords.Length - 1 - arrayElementsPositionInReverse] == secondArrayOfWords[secondArrayOfWords.Length - 1 - arrayElementsPositionInReverse])
                {
                    hasRightCommonEnd = true;
                    numOFCommonWordsInTheRight++;
                }
            }

            if (hasLeftCommonEnd && hasRightCommonEnd)
            {
                if (numOFCommonWordsInTheLeft > numOFCommonWordsInTheRight)
                {
                    Console.WriteLine($"{numOFCommonWordsInTheLeft}");
                }
                else
                {
                    Console.WriteLine($"{numOFCommonWordsInTheRight}");
                }
            }
            else if (hasLeftCommonEnd)
            {
                Console.WriteLine($"{numOFCommonWordsInTheLeft}");
            }
            else if (hasRightCommonEnd)
            {
                Console.WriteLine($"{numOFCommonWordsInTheRight}");
            }
            else if (!hasLeftCommonEnd && !hasRightCommonEnd)
            {
                Console.WriteLine("0");
            }
        }
    }
}
