using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numArray = Console.ReadLine()
                             .Split()
                             .Select(long.Parse)
                             .ToArray();

            bool hasSuchNumbers = false;

            for (long i = 0; i < numArray.Length - 1; i++)
            {
                for (long j = i + 1; j < numArray.Length; j++)
                {
                    for (long k = 0; k < numArray.Length; k++)
                    {
                        if (numArray[i] + numArray[j] == numArray[k])
                        {
                            Console.WriteLine("{0} + {1} == {2}", numArray[i], numArray[j], numArray[k]);
                            hasSuchNumbers = true;
                            break;
                        }
                    }
                }

                
            }
            if (!hasSuchNumbers)
            {
                Console.WriteLine("No");
            }
        }
    }
}
