using System;
using System.Collections.Generic;

namespace RemoveNegativesAnReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Pesho",
                "Gosho",
                "Mimi"
            };

            names.Add("Sisi");
            names.Add("Gosho");
            names.Remove("Gosho");
        }
    }
}
