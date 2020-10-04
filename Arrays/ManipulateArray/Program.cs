using System;
using System.Collections.Generic;
using System.Linq;

namespace ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ').ToArray();
            
            int rowsNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rowsNum; i++)
            {
                string[] command = new string[3];
                command = Console.ReadLine().Split(' ').ToArray();
                int replaceAtIndex = 0;
                string replaceWithString = null;

                if (command[0] == "Replace")
                {
                    replaceAtIndex = int.Parse(command[1]);
                    replaceWithString = command[2];
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
                }
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
            IEnumerable<string> distinctArray = arrayOfMethod.Distinct();
            return distinctArray.ToArray();            
        }

        static string[] Reverse(string[] arrayOfMethod)
        {
            IEnumerable<string> reverseArray = arrayOfMethod.Reverse();
            return reverseArray.ToArray();
        }
    }
}
