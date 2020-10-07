using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            BigInteger numToConvert = BigInteger.Parse(tokens[1]);
            long baseToConvert = long.Parse(tokens[0]);
            StringBuilder numString = new StringBuilder();

            while (numToConvert != 0)
            {
                BigInteger num = numToConvert % baseToConvert;
                
                numString.Append(num);
                numToConvert /= baseToConvert; 
            }

            for (int i = numString.Length - 1; i >= 0; i--)
            {
                Console.Write(numString[i]);
            }
            Console.WriteLine();
              
        }
    }
}
