using System;
using System.Linq;

namespace ReverseAnArrayOfStrigs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringsArray = Console.ReadLine()
                                    .Split()
                                    .ToArray();

            stringsArray = stringsArray.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", stringsArray));
        }
    }
}
