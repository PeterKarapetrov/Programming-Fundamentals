using System;
using System.Linq;

namespace SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ').ToArray();

            string[] command = new string[3];
            command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "END")
            {
                int replaceAtIndex = 0;
                string replaceWithString = null;

                if (command[0] == "Replace")
                {
                    if (int.Parse(command[1]) <= arrayOfStrings.Length - 1 && int.Parse(command[1]) >= 0)
                    {
                        replaceAtIndex = int.Parse(command[1]);
                        replaceWithString = command[2];
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine().Split(' ').ToArray();
                        continue;
                    }
                }

                switch (command[0])
                {
                    case "Reverse":
                        arrayOfStrings = Reverse(arrayOfStrings);
                        break;
                    case "Distinct":
                        arrayOfStrings = Distinct(arrayOfStrings);
                        break;
                    case "Replace":
                        arrayOfStrings = Replace(arrayOfStrings, replaceAtIndex, replaceWithString);
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

                command = Console.ReadLine().Split(' ').ToArray();

            }

            Console.WriteLine(string.Join(", ", arrayOfStrings));

        }

        static string[] Replace(string[] arrayOfStrings, int stringIndex, string replaceWithString)
        {
            arrayOfStrings[stringIndex] = replaceWithString;
            return arrayOfStrings;
        }

        static string[] Distinct(string[] arrayOfMethod)
        {
            return arrayOfMethod.Distinct().ToArray(); ;
        }

        static string[] Reverse(string[] arrayOfMethod)
        {
            return arrayOfMethod.Reverse().ToArray();
        }
    }
}
