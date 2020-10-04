using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Trim();
            for (int i = 0; i < 3; i++)
            {
                string res = input[i];
                Console.WriteLine(res);  
            }
        }
    }
}
