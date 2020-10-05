using System;
using System.Collections.Generic;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commandArray = Console.ReadLine()
                                  .Split();

            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            while (commandArray[0] != "END")
            {
                if (commandArray[0] == "A")
                {
                    phoneBook[commandArray[1]] = commandArray[2];
                }
                else if (commandArray[0] == "S")
                {
                    if (phoneBook.ContainsKey(commandArray[1]))
                    {
                        Console.WriteLine($"{commandArray[1]} -> {phoneBook[commandArray[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {commandArray[1]} does not exist.");
                    }
                }
                else if (commandArray[0] == "ListAll")
                {
                    foreach (var pair in phoneBook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
                commandArray = Console.ReadLine().Split();
            }
        }
    }
}
