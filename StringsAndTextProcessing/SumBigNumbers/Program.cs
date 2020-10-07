using System;
using System.Linq;
using System.Text;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int numOnHand = 0;

            if (firstNum.Length > secondNum.Length)
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }

            for (int index = firstNum.Length - 1; index >= 0; index--)
            {
                int sum = firstNum[index] - 48 + secondNum[index] - 48 + numOnHand;
                int num = sum % 10;
                if (sum > 9)
                {
                    numOnHand = 1;
                }
                else
                {
                    numOnHand = 0;
                }
                result.Append(num);
            }
            if (numOnHand == 1)
            {
                result.Append('1');
            }

            Console.WriteLine(result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
