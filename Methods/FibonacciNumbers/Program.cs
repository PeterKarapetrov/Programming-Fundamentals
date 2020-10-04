using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(ulong.Parse(Console.ReadLine())));
        }

        static ulong Fib(ulong n)
        {
            ulong nNumber = 1;
            ulong prevNum = 0;
            ulong nextNum = 0;
            if (n == 0)
            {
                nNumber = 1;
            }
            else
            {
                for (ulong i = 1; i <= n; i++)
                {
                    nextNum = prevNum + nNumber;
                    prevNum = nNumber;
                    nNumber = nextNum;
                }
            }
            return nNumber;
        }
    }
}
