using System;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];

            for (long index = 0; index < primes.Length; index++)
            {
                primes[index] = true;
            }

            primes[0] = false;
            primes[1] = false;

            for (long indexIsPrime = 0; indexIsPrime < primes.Length; indexIsPrime++)
            {
                if (primes[indexIsPrime])
                {
                    Console.Write($"{indexIsPrime} ");
                    for (long i = 2; i * indexIsPrime < primes.Length ; i++)
                    {
                        primes[i * indexIsPrime] = false;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
