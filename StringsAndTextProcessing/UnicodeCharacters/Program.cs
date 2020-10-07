using System;
using System.Text;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

           
            for (int i = 0; i < inputLine.Length; i++)
			{
                Console.Write("\\u{0:x4}", (int)inputLine[i]);
            }
            Console.WriteLine();
            
        }
    }
}
