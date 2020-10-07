using System;
using System.Linq;
using System.Text.RegularExpressions;
    

namespace MatchHexidecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0x)?([0-9A-F]+)\b";
            string inputLine = Console.ReadLine();

            var hexNumbers = Regex.Matches(inputLine, pattern).Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", hexNumbers));
        }
    }
}
