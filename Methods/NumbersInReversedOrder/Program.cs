using System;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberInReversedOrder(Console.ReadLine());
        }

        static void NumberInReversedOrder(string numString)
        {
            string numberInReversedOrder = string.Empty;
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                Console.Write(numString[i]);
            }
            Console.WriteLine();
        }
    }
}
