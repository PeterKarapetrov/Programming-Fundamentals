using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textLines = File.ReadAllLines("lines.txt");
            List<string> oddLines = new List<string>();
            //oddLines = textLines.Where((line, index) => index % 2 == 1).ToList();
            for (int i = 0; i < textLines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(textLines[i]);
                }
            }
            File.WriteAllLines("odd-lines.txt", oddLines.ToArray());
        }
    }
}
