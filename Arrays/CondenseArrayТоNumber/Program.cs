using System;
using System.Linq;

namespace CondenseArrayТоNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();


            if (numArray.Length == 0)
            {
                Console.WriteLine(numArray[0]);
                return;
            }

            int lenght = numArray.Length;

            while (lenght > 1)
            {
                for (int index = 0; index < lenght - 1; index++)
                {
                    numArray[index] = numArray[index] + numArray[index + 1];
                }
                numArray[lenght - 1] = 0;
                lenght--;
            }

            Console.WriteLine(numArray[0]);
        }
    }
}
