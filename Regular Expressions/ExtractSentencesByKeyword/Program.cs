using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] sentances = Console.ReadLine().Split(new char[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = $@"\W{word}\W";

            foreach (var sentance in sentances)
            {
                if (Regex.IsMatch(sentance, pattern))
                {
                    Console.WriteLine(sentance.Trim());
                }
            }
        }
    }
}
