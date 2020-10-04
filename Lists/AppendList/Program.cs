using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numsAsStringList = Console.ReadLine()
                                           .Split('|')
                                           .ToList();

            numsAsStringList.Reverse();

            List<int> numList = new List<int>();

            foreach (string word in numsAsStringList)
            {
                numList.AddRange(word.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            }

            Console.WriteLine(string.Join(" ", numList));
        }
    }
}
