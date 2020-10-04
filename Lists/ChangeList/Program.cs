using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().
                                     Split(' ').
                                     Select(int.Parse).
                                     ToList();

            string[] command = Console.ReadLine().
                                  Split(' ').
                                  ToArray();

            int insertElement = 0;
            int insertPosition = 0;
            int deleteElementWithValue = 0;

            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command.Count() == 2)
                {
                    deleteElementWithValue = int.Parse(command[1]);
                }
                else if (command.Count() == 3)
                {
                    insertElement = int.Parse(command[1]);
                    insertPosition = int.Parse(command[2]);
                }

                switch (command[0])
                {
                    case "Delete":
                        inputList.RemoveAll(t => t == deleteElementWithValue);
                        break;
                    case "Insert":
                        inputList.Insert(insertPosition, insertElement);
                        break;
                }

                command = Console.ReadLine().
                                  Split(' ').
                                  ToArray();
            }

            if (command[0] == "Odd")
            {
                foreach (int num in inputList)
                {
                    if (num % 2 != 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
            else if (command[0] == "Even")
            {
                foreach (int num in inputList)
                {
                    if (num % 2 == 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
