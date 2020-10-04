using System;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EnglishNameOfLastDigit(Math.Abs(long.Parse(Console.ReadLine()))));
        }

        static string EnglishNameOfLastDigit(long num)
        {
            string englishNameOfLastDigit = string.Empty;
            long lastDigit = num % 10;
            switch (lastDigit)
            {
                case 1:
                    englishNameOfLastDigit = "one";
                    break;
                case 2:
                    englishNameOfLastDigit = "two";
                    break;
                case 3:
                    englishNameOfLastDigit = "three";
                    break;
                case 4:
                    englishNameOfLastDigit = "four";
                    break;
                case 5:
                    englishNameOfLastDigit = "five";
                    break;
                case 6:
                    englishNameOfLastDigit = "six";
                    break;
                case 7:
                    englishNameOfLastDigit = "seven";
                    break;
                case 8:
                    englishNameOfLastDigit = "eight";
                    break;
                case 9:
                    englishNameOfLastDigit = "nine";
                    break;
                case 0:
                    englishNameOfLastDigit = "zero";
                    break;
            }
            return englishNameOfLastDigit;
        }
    }
}
