using System;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())), int.Parse(Console.ReadLine())));
        }

        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
