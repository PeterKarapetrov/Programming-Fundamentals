using System;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong rangeEndNum = ulong.Parse(Console.ReadLine());

            for (ulong num = 1; num <= rangeEndNum ; num++)
            {
                if (NumIsPolidrome(num))
                {
                    if (NumberContainEvenDigit(num))
                    {
                        if (SumOfNumberDigits(num))
                        {
                            Console.WriteLine($"{num}");
                        }
                    }
                }
            }
        }

        static bool SumOfNumberDigits(ulong num)
        {
            ulong sumOfDigits = 0;
            ulong digit = 0;
            while (num > 0)
            {
                digit = num % 10;
                sumOfDigits += digit;
                num /= 10;
            }
            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool NumberContainEvenDigit(ulong num)
        {
            bool numberContainEvenDigit = false;
            ulong digit = 0;
            while (num > 0)
            {
                digit = num % 10;
                if (digit % 2 == 0)
                {
                    numberContainEvenDigit = true;
                    break;
                }
                num /= 10;
            }
            return numberContainEvenDigit;        
        }

        static bool NumIsPolidrome(ulong num)
        {
            ulong digit = 0;
            ulong reverseNum = 0;
            ulong givenNum = num;
            while (num > 0)
            {
                digit = num % 10;
                reverseNum = reverseNum * 10 + digit;
                num /= 10;
            }

            if (givenNum == reverseNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
