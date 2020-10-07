using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = @"([A-Z]{2})([\d]{2}\.[\d]{1,2})([a-zA-Z]+)(?:\|)";
            Dictionary<string, List<string>> weather = new Dictionary<string, List<string>>();
            
            while (inputLine != "end")
            {
                string cityName = null;
                string temperature = null;
                string weatherType = null;
                MatchCollection matches = Regex.Matches(inputLine, pattern);

                foreach (Match match in matches)
                {
                    cityName = match.Groups[1].Value;
                    temperature = match.Groups[2].Value;
                    weatherType = match.Groups[3].Value;

                    List<string> cityRecords = new List<string>();
                    cityRecords.Add(cityName);
                    cityRecords.Add(temperature);
                    cityRecords.Add(weatherType);
                    weather[cityName] = cityRecords;
                }
                inputLine = Console.ReadLine();
            }

            foreach (var pair in weather.OrderBy(a => double.Parse(a.Value[1])))
            {
                Console.WriteLine($"{pair.Value[0]} => {double.Parse(pair.Value[1]):f2} => {pair.Value[2]}");
            }

        }
    }
}
