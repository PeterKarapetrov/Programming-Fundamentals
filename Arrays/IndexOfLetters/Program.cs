using System;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = new char[26];
            int index = 0;

            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                charArray[index] = letter;
                index++;
            }

            string inputString = Console.ReadLine();

            for (int letter = 0; letter < inputString.Length; letter++)
            {
                for (int indexInCharArray = 0; indexInCharArray < charArray.Length; indexInCharArray++)
                {
                    if (inputString[letter] == charArray[indexInCharArray])
                    {
                        Console.WriteLine($"{inputString[letter]} -> {indexInCharArray}");
                    }
                }
            }
        }
    }
}
