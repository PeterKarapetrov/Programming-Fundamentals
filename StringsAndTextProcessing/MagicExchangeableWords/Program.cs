using System;
using System.Linq;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            string firstString = tokens[0];
            string secondtString = tokens[1];

            Console.WriteLine(IsExchangable(firstString, secondtString));
        }

        static string IsExchangable(string firstString, string secondtString)
        {
            return (firstString.Distinct().Count() == secondtString.Distinct().Count()).ToString().ToLower();
        }
    }
}
