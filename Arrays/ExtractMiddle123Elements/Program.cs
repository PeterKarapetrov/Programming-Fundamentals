using System;
using System.Linq;

namespace ExtractMiddle123Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();

            int arrayLength = numArray.Length;

            if (arrayLength == 1)
            {
                Console.WriteLine("{ " + $"{numArray[0]}" + " }");
            }
            else if (arrayLength % 2 == 0)
            {
                int position = arrayLength / 2 - 1;
                Console.WriteLine("{ " + $"{numArray[position]}" + ", " + $"{numArray[position + 1]}" + " }");
            }
            else if (arrayLength % 2 != 0)
            {
                int position = arrayLength / 2 - 1;
                Console.WriteLine("{ " + $"{numArray[position]}" + ", " + $"{numArray[position + 1]}" + ", " + $"{numArray[position + 2]}" + " }");
            }
        }
    }
}
