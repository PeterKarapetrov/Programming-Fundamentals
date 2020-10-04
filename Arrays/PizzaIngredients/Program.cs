using System;
using System.Linq;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingradientsArray = Console.ReadLine()
                                        .Split()
                                        .ToArray();

            int validIngradientLength = int.Parse(Console.ReadLine());

            string[] validIngradientsArray = new string[ingradientsArray.Length];
            int lastEmptyIndex = 0;

            for (int index = 0; index < ingradientsArray.Length; index++)
            {
                if (ingradientsArray[index].Length == validIngradientLength)
                {
                    validIngradientsArray[lastEmptyIndex] = ingradientsArray[index];
                    lastEmptyIndex++;
                    Console.WriteLine($"Adding {ingradientsArray[index]}.");
                    if (lastEmptyIndex == 10)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Made pizza with total of {lastEmptyIndex} ingredients.");
            Console.WriteLine("The ingredients are: " + string.Join(", ", validIngradientsArray.Take(lastEmptyIndex).ToArray()) + "."); 
        }
    }
}
