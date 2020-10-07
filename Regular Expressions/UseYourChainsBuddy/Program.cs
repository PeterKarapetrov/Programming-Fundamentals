using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = @"(?<=<p>)(?<text>.*?)(?=<\/p>)";

            MatchCollection matches = Regex.Matches(inputLine, pattern);
            StringBuilder encryptedText = new StringBuilder();

            foreach (Match match in matches)
            {
                string text = Regex.Replace(match.Groups["text"].Value, @"([^a-z0-9]+)", " ").Trim();
                
                for (int i = 0; i < text.Length; i++)    
                {
                    char symbol = text[i];
                    if (symbol >= 'a' && symbol <= 'm' )
                    {
                        symbol = (char)(symbol + 13);
                    }
                    else if (symbol > 'm' && symbol <= 'z')
                    {
                        symbol = (char)(symbol - 13);
                    }
                    encryptedText.Append($"{symbol}");
                }
                encryptedText.Append(" ");
            }
            Console.WriteLine($"{encryptedText.ToString().TrimEnd()}");
        }
    }
}
