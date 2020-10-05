using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine()
                                  .ToLower()
                                  .Split()
                                  .ToArray();

            var wordsDictionary = new Dictionary<string, int>();

            foreach (string word in inputArray)
            {
                if (wordsDictionary.ContainsKey(word) == false)
                {
                    wordsDictionary.Add(word, 0);
                }
                wordsDictionary[word]++;
            }

            List<string> resultStringList = new List<string>();

            foreach (var pair in wordsDictionary)
            {
                if (pair.Value % 2 != 0)
                {
                    resultStringList.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", resultStringList));
        }



    }
}
