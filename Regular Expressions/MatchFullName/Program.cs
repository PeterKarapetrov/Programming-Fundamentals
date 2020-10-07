using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexPattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(input, regexPattern);

            foreach (Match match in matchedNames)
            {
                Console.Write(match.Value + ' ');
            }

            Console.WriteLine();            
        }
    }
}
