using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().
                                  Split().
                                  Select(int.Parse).
                                  ToList();

            string[] command = Console.ReadLine().
                               Split().
                               ToArray();

            while (command[0] != "print")
            {

                switch (command[0])
                {
                    case "add":
                        int addAtIndex = int.Parse(command[1]);
                        int addElement = int.Parse(command[2]);
                        inputList.Insert(addAtIndex, addElement);
                        break;
                    case "addMany":
                        int addIndex = int.Parse(command[1]);
                        AddMany(inputList, addIndex, command);
                        break;
                    case "contains":
                        int containsElement = int.Parse(command[1]);
                        Contains(inputList, containsElement);
                        break;
                    case "remove":
                        int removeAtIndex = int.Parse(command[1]);
                        inputList.RemoveAt(removeAtIndex);
                        break;
                    case "shift":
                        int shiftNum = int.Parse(command[1]) % inputList.Count;
                        inputList = ShiftList(inputList, shiftNum);
                        break;
                    case "sumPairs":
                        inputList = SumPairs(inputList);
                        break;
                }
                command = Console.ReadLine().Split().ToArray();
            }

            if (command[0] == "print")
            {
                Console.Write("[");
                for (int i = 0; i < inputList.Count - 1; i++)
                {
                    Console.Write($"{inputList[i]}, ");
                }
                Console.Write($"{inputList[inputList.Count - 1]}");
                Console.Write("]");
                Console.WriteLine();
            }
        }

        static void Contains(List<int> inputList, int containsElement)
        {
            if (inputList.Contains(containsElement))
            {
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] == containsElement)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("-1");
            }
        }


        static void AddMany(List<int> inputList, int addIndex, string[] command)
        {
            int[] AddNumbersRange = new int[command.Length - 2];
            for (int index = 0; index < AddNumbersRange.Length; index++)
            {
                AddNumbersRange[index] = int.Parse(command[index + 2]);
            }
            IEnumerable<int> addRange = AddNumbersRange.AsEnumerable<int>();
            inputList.InsertRange(addIndex, addRange);      
        }

        static List<int> ShiftList(List<int> inputList, int shiftNum)
        {
            List<int> shiftedList = inputList.ToList<int>();
            for (int index = 0; index < inputList.Count; index++)
            {
                int newIndex = (index + (inputList.Count - shiftNum)) % inputList.Count;
                shiftedList[newIndex] = inputList[index];
            }
            return shiftedList;
        }

        static List<int> SumPairs(List<int> inputList)
        {
            List<int> sumPairsList = new List<int>();
            if (inputList.Count % 2 == 0)
            {
                for (int index = 0; index < inputList.Count - 1; index += 2)
                {
                    sumPairsList.Add(inputList[index] + inputList[index + 1]);
                }
                return sumPairsList;
            }
            else
            {
                for (int index = 0; index < inputList.Count - 1; index += 2)
                {
                    sumPairsList.Add(inputList[index] + inputList[index + 1]);
                }
                sumPairsList.Add(inputList[inputList.Count - 1]);
                return sumPairsList;
            } 
        }
    }
}
