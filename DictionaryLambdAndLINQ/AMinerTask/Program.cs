using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> minerDictionary = new Dictionary<string, long>();

            string inputLineString = Console.ReadLine();
            int counter = 1;
            string resourceOnPrevLine = null;

            while (inputLineString != "stop")
            {
                if (counter % 2 != 0)
                {
                    if (minerDictionary.ContainsKey(inputLineString) == false)
                    {
                        minerDictionary.Add(inputLineString, 0);
                        resourceOnPrevLine = inputLineString;
                    }
                    else
                    {
                        resourceOnPrevLine = inputLineString;
                    }
                }
                else if (counter % 2 == 0)
                {
                    minerDictionary[resourceOnPrevLine] += long.Parse(inputLineString);
                }
                counter++;
                inputLineString = Console.ReadLine();
            }
            foreach (var pair in minerDictionary)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
