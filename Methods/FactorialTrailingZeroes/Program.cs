using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintNumFactoriel(num);
        }

        private static void PrintNumFactoriel(int num)
        {
            BigInteger factoriel = 1;
            for (int i = 1; i <= num; i++)
            {
                factoriel *= i;
            }
            long zeroCount = 0;
            while (factoriel > 0)
            {                
                int lastDigit = (int)(factoriel % 10);
                factoriel /= 10;
                if (lastDigit == 0)
                {
                    zeroCount += 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"{zeroCount}");            
        }
    }
}
