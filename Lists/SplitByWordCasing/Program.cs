using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = Console.ReadLine()
                                      .Split(", ; : . ! ( ) \" ' \\ / [ ] ' '".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                                      .ToList();

            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (string word in stringList)
            {
                if (word.All(letter => letter > 96 && letter < 123))
                {
                    lowerCase.Add(word);
                }
                else if (word.All(letter => letter > 64 && letter < 91))
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}
