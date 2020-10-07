using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder inputText = new StringBuilder();
            inputText.Append(Console.ReadLine());
            StringBuilder patternText = new StringBuilder();
            patternText.Append(Console.ReadLine());
            StringBuilder resultText = new StringBuilder();
            resultText = inputText;
            string pattern = @patternText.ToString();

            MatchCollection matches = Regex.Matches(inputText.ToString(), pattern);

            while (matches.Count > 1)
            {
                int matchLenght = patternText.Length;
                int matchIndex = matches[matches.Count - 1].Index;
                resultText = inputText.Remove(matchIndex, matchLenght);
                matchIndex = matches[0].Index;
                resultText = inputText.Remove(matchIndex, matchLenght);
                Console.WriteLine("Shaked it.");
                int removeCharAtIndex = matchLenght / 2;
                patternText.Remove(removeCharAtIndex, 1);                
                pattern = @patternText.ToString();
                matches = Regex.Matches(inputText.ToString(), pattern);
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(resultText.ToString());
        }
    }
}
