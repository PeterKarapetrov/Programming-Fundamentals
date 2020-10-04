using System;

namespace PrimeCheker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((IsPrime(ulong.Parse(Console.ReadLine()))));
        }

        static bool IsPrime(ulong num)
        {
            bool numIsPrime = true;
            for (ulong i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    numIsPrime = false;
                    break;
                }
            }
            if (num == 0 || num == 1)
            {
                numIsPrime = false;
            }
            return numIsPrime;
        }
    }
}
