using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();
            string patternKey = @"^([a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)([a-zA-Z]*)$";
            var keyMatch = Regex.Match(keyString, patternKey);

            if (keyMatch.Success)
            {
                string keyStart = keyMatch.Groups[1].Value;
                string keyEnd = keyMatch.Groups[2].Value;
                
                string patternText = $@"{keyStart}(.*?){keyEnd}";
                var resultString = new StringBuilder();
                MatchCollection matches = Regex.Matches(textString, patternText);

                foreach (Match match in matches)
                {
                    resultString.Append(match.Groups[1].Value);
                }

                if (resultString.Length == 0)
                {
                    Console.WriteLine("Empty result");
                }
                else
                {
                    Console.WriteLine(resultString.ToString());
                }
            }
            
        }
    }
}
