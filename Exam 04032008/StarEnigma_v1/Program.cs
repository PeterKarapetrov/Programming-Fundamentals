using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace StarEnigma_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            int attackedPlanetCount = 0;
            int destroyedPlanetCount = 0;
            List<string> attackedPlanetList = new List<string>();
            List<string> destroyedPlanetList = new List<string>();


            for (int i = 0; i < numberOfMessages; i++)
            {
                bool messageIsValid = true;
                int decriptionKey = 0;
                string inputLine = Console.ReadLine();
                for (int index = 0; index < inputLine.Length; index++)
                {
                    if (inputLine[index] == 's' || inputLine[index] == 't' || inputLine[index] == 'a' || inputLine[index] == 'r'
                        || inputLine[index] == 'S' || inputLine[index] == 'T' || inputLine[index] == 'A' || inputLine[index] == 'R')
                    {
                        decriptionKey++;
                    }
                }
                StringBuilder decriptedMessage = new StringBuilder();

                foreach (var symbol in inputLine)
                {
                    decriptedMessage.Append((char)(symbol - decriptionKey));
                }
                string message = decriptedMessage.ToString();

                string planetPattern = @"@(?<planet>[a-zA-z]+)";
                string populationPattern = @":[-]?(?<population>[0-9]+)";
                string attackerPattern = @"!(?<attackType>[AD]+)!";
                string soldierCountPattern = @"->[-]?(?<soldierCount>[0-9]+)";
                string planetName = null;
                string planetType = null;

                if (Regex.IsMatch(message, planetPattern))
                {
                    Match match = Regex.Match(message, planetPattern);
                    planetName = match.Groups["planet"].Value;
                }
                else
                {
                    messageIsValid = false;
                }

                if (Regex.IsMatch(message, populationPattern) == false)
                {
                    messageIsValid = false;
                }
                else
                {
                    string population = Regex.Match(message, populationPattern).Groups["population"].Value;
                    if (population.Length > 10)
                    {
                        messageIsValid = false;
                    }
                }

                if (Regex.IsMatch(message, attackerPattern) == true)
                {
                    Match match = Regex.Match(message, attackerPattern);
                    if (match.Groups["attackType"].Value.Length > 1)
                    {
                        messageIsValid = false;
                    }
                    planetType = match.Groups["attackType"].Value;
                }
                else
                {
                    messageIsValid = false;
                }

                if (Regex.IsMatch(message, soldierCountPattern) == false)
                {
                    messageIsValid = false;
                }
                else
                {
                    string soldier = Regex.Match(message, soldierCountPattern).Groups["soldierCount"].Value;
                    if (soldier.Length > 10)
                    {
                        messageIsValid = false;
                    }
                }

                if (messageIsValid == true)
                {
                    if (planetType == "A")
                    {
                        attackedPlanetCount++;
                        attackedPlanetList.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanetCount++;
                        destroyedPlanetList.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanetCount}");
            foreach (var planet in attackedPlanetList.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanetCount}");
            foreach (var planet in destroyedPlanetList.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
