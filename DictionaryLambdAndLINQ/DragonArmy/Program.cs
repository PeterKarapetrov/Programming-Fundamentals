using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, Dragon>> dragonArmy = new Dictionary<string, Dictionary<string, Dragon>>();
            int dragonsNum = int.Parse(Console.ReadLine());
            Dictionary<string, Dragon> dragonSet;

            for (int num = 0; num < dragonsNum; num++)
            {
                List<string> inputLine = Console.ReadLine().Split().ToList();
                dragonSet = new Dictionary<string, Dragon>();
                string dragonType = inputLine[0];
                Dragon dragon = new Dragon();
                dragon.Name = inputLine[1];
                int damage = 0;
                int health = 0;
                int armor = 0;
                if (int.TryParse(inputLine[2], out damage) == false)
                {
                    dragon.Damage = 45;
                }
                else
                {
                    dragon.Damage = damage;
                }

                if (int.TryParse(inputLine[3], out health) == false)
                {
                    dragon.Health = 250;
                }
                else
                {
                    dragon.Health = health;
                }

                if (int.TryParse(inputLine[4], out armor) == false)
                {
                    dragon.Armor = 10;
                }
                else
                {
                    dragon.Armor = armor;
                }
                
                if (dragonArmy.ContainsKey(dragonType) == false)
                {
                    dragonSet.Add(dragon.Name, dragon);
                    dragonArmy.Add(dragonType, dragonSet);
                }
                else
                {
                    if (dragonArmy[dragonType].ContainsKey(dragon.Name) == false)
                    {
                        dragonArmy[dragonType].Add(dragon.Name, dragon);
                    }
                    else
                    {
                        dragonArmy[dragonType][dragon.Name] = dragon;
                    }
                }
            }

            foreach (var drag in dragonArmy)
            {
                Console.WriteLine($"{drag.Key}::({drag.Value.Values.Average(x => x.Damage):f2}/{drag.Value.Values.Average(x => x.Health):f2}/{drag.Value.Values.Average(x => x.Armor):f2})");
                foreach (var pair in drag.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{pair.Key} -> damage: {pair.Value.Damage}, health: {pair.Value.Health}, armor: {pair.Value.Armor}");
                }
            }

        }
    }

    class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }    
    }
}
