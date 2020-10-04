using System;
using System.Linq;

namespace SequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());


            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            
            string command = Console.ReadLine();
            
            int[] argsParam = new int[2];


            while (!command.Equals("stop"))
            {
                string[] args = command.Split(ArgumentsDelimiter);
                if (args[0] == "add" ||
                    args[0] == "subtract" ||
                    args[0] == "multiply")
                {
                    argsParam[0] = int.Parse(args[1]);
                    argsParam[1] = int.Parse(args[2]);
                }

                PerformAction(array, args[0], argsParam);
                
                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr;
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos - 1] *= value;
                    break;
                case "add":
                    array[pos - 1] += value;
                    break;
                case "subtract":
                    array[pos - 1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
            PrintArray(array);
            arr = array;
        }

        private static void ArrayShiftRight(long[] array)
        {
            long oldEnd = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = oldEnd;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long oldStart = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = oldStart;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
