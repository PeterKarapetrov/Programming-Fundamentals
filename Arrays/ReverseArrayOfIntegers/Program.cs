using System;
using System.Linq;

namespace ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] numArray = new int[num];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }        

            numArray = numArray.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", numArray));
        }
    }
}
