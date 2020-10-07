using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split(new char[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> validUsernames = new List<string>();

            for (int index = 0; index < inputLine.Length; index++)
            {
                string pattern = @"(^[a-zA-Z][\w]{2,24}$)";
                Match match = Regex.Match(inputLine[index], pattern);
                if (match.Success)
                {
                   validUsernames.Add(match.Value);
                }
            }
            int maxLenght = 0;
            int resultCoupleStartIndex = 0;

            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                if ((validUsernames[i].Length + validUsernames[i + 1].Length) > maxLenght)
                {
                    maxLenght = (validUsernames[i].Length + validUsernames[i + 1].Length);
                    resultCoupleStartIndex = i;
                }
            }

            Console.WriteLine(validUsernames[resultCoupleStartIndex]);
            Console.WriteLine(validUsernames[resultCoupleStartIndex + 1]);

        }
    }
}
