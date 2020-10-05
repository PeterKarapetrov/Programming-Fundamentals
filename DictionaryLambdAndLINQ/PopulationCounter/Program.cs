using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countryPopulationDD = new Dictionary<string, Dictionary<string, long>>();

            List<string> inputLineList = Console.ReadLine().Split('|').ToList();

            while (inputLineList[0] != "report")
            {
                string country = inputLineList[1];
                string city = inputLineList[0];
                long population = long.Parse(inputLineList[2]);

                if (countryPopulationDD.ContainsKey(country) == false)
                {
                    Dictionary<string, long> cityPopulationD = new Dictionary<string, long>();

                    cityPopulationD[city] = population;
                    countryPopulationDD[country] = cityPopulationD;
                }
                else
                {
                    if (countryPopulationDD[country].ContainsKey(city) == false)
                    {
                        countryPopulationDD[country].Add(city, population);
                    }
                    else
                    {
                        countryPopulationDD[country][city] += population;
                    }
                }

                inputLineList = Console.ReadLine().Split('|').ToList();
            }

            foreach (var pair in countryPopulationDD.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{pair.Key} (total population: {pair.Value.Values.Sum()})");
                foreach (var town in pair.Value.OrderByDescending(y => y.Value))
                {
                    Console.WriteLine($"=>{town.Key}: {town.Value}");
                }
            }
            Console.WriteLine();
        }
    }
}
