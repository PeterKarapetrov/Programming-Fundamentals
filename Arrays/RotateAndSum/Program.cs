using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayOfNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotateTimes = int.Parse(Console.ReadLine());

            int[] ReverseArrayOfNum = new int[ArrayOfNum.Length];
            int[] SumOfNum = new int[ArrayOfNum.Length];

            for (int rotation = 1; rotation <= rotateTimes; rotation++)
            {
                for (int elements = 0; elements < ArrayOfNum.Length; elements++)
                {
                    ReverseArrayOfNum[(elements + rotation) % ArrayOfNum.Length] = ArrayOfNum[elements];
                    SumOfNum[(elements + rotation) % ArrayOfNum.Length] += ReverseArrayOfNum[(elements + rotation) % ArrayOfNum.Length];
                }
            }

            for (int i = 0; i < ArrayOfNum.Length; i++)
            {
                Console.Write($"{SumOfNum[i]} ");
            }
            Console.WriteLine();
        }
    }
}
