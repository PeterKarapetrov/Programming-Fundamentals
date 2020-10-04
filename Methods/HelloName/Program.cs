using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelloName(Console.ReadLine()));
        }

        static string HelloName(string name)
        {
            return "Hello, " + name + '!';
        }
    }
}
