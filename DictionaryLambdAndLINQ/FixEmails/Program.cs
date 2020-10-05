using System;
using System.Collections.Generic;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailBook = new Dictionary<string, string>();
            int counter = 1;
            string prevName = null;
            string inputLine = Console.ReadLine();

            while (inputLine != "stop")
            {
                if (counter % 2 != 0)
                {
                    if (emailBook.ContainsKey(inputLine) == false)
                    {
                        emailBook.Add(inputLine, null);
                        prevName = inputLine;
                    }
                    else
                    {
                        prevName = inputLine;
                    }
                }
                else
                {
                    emailBook[prevName] = inputLine;
                }
                counter++;
                inputLine = Console.ReadLine();
            }

            foreach (var pair in emailBook)
            {
                if (pair.Value.EndsWith("us") || pair.Value.EndsWith("uk"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
