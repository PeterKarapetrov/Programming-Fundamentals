using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryMaterialsD = new Dictionary<string, int>();
            legendaryMaterialsD.Add("shards", 0);
            legendaryMaterialsD.Add("fragments", 0);
            legendaryMaterialsD.Add("motes", 0);

            SortedDictionary<string, int> junkMaterialsD = new SortedDictionary<string, int>();

            List<string> inputLine = new List<string>();

            while (true)
            {
                inputLine = Console.ReadLine().Split().ToList();

                string material = null;
                int materialQuantity = 0;
                int shardsQty = 0;
                int motesQty = 0;
                int fragmentsQty = 0;

                for (int index = 0; index < inputLine.Count; index += 2)
                {
                    materialQuantity = int.Parse(inputLine[index]);
                    material = inputLine[index + 1].ToLower();

                    if (legendaryMaterialsD.ContainsKey(material))
                    {
                        legendaryMaterialsD[material] += materialQuantity;
                    }
                    else
                    {
                        if (junkMaterialsD.ContainsKey(material))
                        {
                            junkMaterialsD[material] += materialQuantity;
                        }
                        else
                        {
                            junkMaterialsD.Add(material, materialQuantity);
                        }
                        
                    }

                    legendaryMaterialsD.TryGetValue("shards", out shardsQty);
                    legendaryMaterialsD.TryGetValue("fragments", out fragmentsQty);
                    legendaryMaterialsD.TryGetValue("motes", out motesQty);
                    if (shardsQty >= 250 || fragmentsQty >= 250 || motesQty >= 250)
                    {
                        break;
                    }
                }

                if (shardsQty >= 250)
                {
                    Console.WriteLine("Shadowmourne obtained!");
                    legendaryMaterialsD["shards"] -= 250;
                    break;
                }
                else if (fragmentsQty >= 250)
                {
                    Console.WriteLine("Valanyr obtained!");
                    legendaryMaterialsD["fragments"] -= 250;
                    break;
                }
                else if (motesQty >= 250)
                {
                    Console.WriteLine("Dragonwrath obtained!");
                    legendaryMaterialsD["motes"] -= 250;
                    break;
                }
            }

            foreach (var pair in legendaryMaterialsD.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            foreach (var pair in junkMaterialsD.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
          
        }
    }
}
