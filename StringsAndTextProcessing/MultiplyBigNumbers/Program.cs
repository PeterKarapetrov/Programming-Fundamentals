using System;
using System.Text;
using System.Linq;


namespace MultiplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int numOnHand = 0;
            int sum = 0;

            if (secondNum == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = firstNum.Length - 1; i >= 0 ; i--)
            {
                
                sum = (firstNum[i] - 48) * secondNum + numOnHand;
                int num = sum % 10;
                result.Append(num);
                if (sum > 9)
                {
                    numOnHand = sum / 10;
                }
                else
                {
                    numOnHand = 0;
                }
            }

            if (numOnHand != 0)
            {
                result.Append(numOnHand);
            }

            Console.WriteLine(result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
