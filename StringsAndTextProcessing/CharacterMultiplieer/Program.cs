using System;

namespace CharacterMultiplieer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            string firstString = tokens[0];
            string secondtString = tokens[1];

            Console.WriteLine(SumAndMultiplyStrings(firstString, secondtString));
        }

        static int SumAndMultiplyStrings(string firstString, string secondtString)
        {
            int sum = 0;
            for (int index = 0; index < Math.Min(firstString.Length, secondtString.Length); index++)
            {
                sum += firstString[index] * secondtString[index]; 
            }

           

            for (int index = Math.Min(firstString.Length, secondtString.Length); index < Math.Max(firstString.Length, secondtString.Length) ; index++)
            {
                try
                {
                    sum += firstString[index];
                }
                catch
                {
                    sum += secondtString[index];
                }
            }

            return sum;
        }
    }
}
