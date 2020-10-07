using System;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConvertFromBase_NtoBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            BigInteger baseNum = BigInteger.Parse(tokens[0]);
            StringBuilder numToConvert = new StringBuilder();
            numToConvert.Append(tokens[1]);
            BigInteger resultNum = 0;
            int power = numToConvert.Length - 1;
            
            for (int i = 0; i < numToConvert.Length; i++)
            {
                resultNum += int.Parse(numToConvert[i].ToString()) * BigInteger.Pow(baseNum, power);
                power--;
            }

            Console.WriteLine(resultNum);
        }
    }
}
