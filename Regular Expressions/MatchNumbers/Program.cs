using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))\-?\d+(\.\d+)?($|(?=\s))";

            string inputLine = Console.ReadLine();

            var names = Regex.Matches(inputLine, pattern);

            foreach (Match name in names)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
