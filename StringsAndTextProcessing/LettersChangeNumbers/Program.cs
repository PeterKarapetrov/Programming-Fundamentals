using System;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] tokens = Console.ReadLine().Split(new char[] { ' ', '\t'  }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal sum = 0;

                for (int index = 0; index < tokens.Length; index++)
                {
                    char letterStart = tokens[index].ElementAt(0);
                    char letterEnd = tokens[index].ElementAt(tokens[index].Length - 1);
                    string temp = tokens[index].Remove(tokens[index].Length - 1);
                    decimal num = decimal.Parse(temp.Substring(1));

                    if (letterStart >= 'A' && letterStart <= 'Z')
                    {
                        num = num / (letterStart - 64);
                    }
                    else
                    {
                        num = num * (letterStart - 96);
                    }

                    if (letterEnd >= 'A' && letterEnd <= 'Z')
                    {
                        num = num - (letterEnd - 64);
                    }
                    else
                    {
                        num = num + (letterEnd - 96);
                    }

                    sum += num;
                }

                Console.WriteLine($"{sum:f2}");
                      
        }
    }
}
