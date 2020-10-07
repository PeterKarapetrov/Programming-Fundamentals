using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                string key = string.Empty;
                string value = string.Empty;
                Dictionary<string, string> result = new Dictionary<string, string>();
                string pattern = @"(?<key>[^&=?]*)=(?<value>[^&=]*)";
                MatchCollection matches = Regex.Matches(inputLine, pattern);
                string patternSpace1 = @"%20";
                string patternSpace2 = @"\+";

                foreach (Match match in matches)
                {
                    key = Regex.Replace(match.Groups[1].Value, patternSpace1, " ");
                    value = Regex.Replace(match.Groups[2].Value, patternSpace1, " ");
                    key = Regex.Replace(key, patternSpace2, " ");
                    value = Regex.Replace(value, patternSpace2, " ");
                    key = key.Trim();
                    value = value.Trim();
                    key = Regex.Replace(key, @"[\s]+", " ");
                    value = Regex.Replace(value, @"[\s]+", " ");

                    if (result.ContainsKey(key) == false)
                    {
                        result.Add(key, value);
                    }
                    else
                    {
                        result[key] += ", " + value;
                    }
                }

                foreach (var pair in result)
                {
                    Console.Write(pair.Key + "=[" + pair.Value +"]");
                }
                Console.WriteLine();
                inputLine = Console.ReadLine();
            }
        }
    }
}
