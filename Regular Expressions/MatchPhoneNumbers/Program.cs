using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^| )\+359( |-)2(\2)(\d{3})(\2)(\d{4})\b";
            string inputLine = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(inputLine, pattern);

            var matchPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchPhones));
        }
    }
}
