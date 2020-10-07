using System;
using System.Text.RegularExpressions;


namespace ExtractEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))([a-z0-9]+)([.\-_][a-z0-9]+)?@([a-z0-9]+)([.\-_][a-z0-9]+)?\.[a-z]+(([.][a-z]+)*)";
            string inputLine = Console.ReadLine();

            var matches = Regex.Matches(inputLine, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
