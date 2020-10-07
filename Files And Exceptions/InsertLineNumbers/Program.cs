using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InsertLineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputText = File.ReadAllLines("input.txt").ToList();
            for (int i = 0; i < inputText.Count; i++)
            {
                inputText[i] = inputText[i].Insert(0, $"{i + 1}. ");
            }
            File.Delete("output.txt");
            File.WriteAllLines("output.txt", inputText.ToArray());
        }
    }
}
