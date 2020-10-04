using System;

namespace LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfElements = int.Parse(Console.ReadLine());
            int sumNumberElements = int.Parse(Console.ReadLine());

            long[] elementsArray = new long[numOfElements];

            if (numOfElements == 0)
            {
                return;
            }
            else
            {
                elementsArray[0] = 1;
               
                for (int i = 1; i < elementsArray.Length; i++)
                {
                    if (sumNumberElements > i - 1 )
                    {
                        long sum = 0;
                        for (int j = 0; j < i; j++)
                        {
                            sum += elementsArray[j];
                        }
                        elementsArray[i] = sum;
                    }
                    else
                    {
                        int starIndexSum = i - sumNumberElements;
                        long sum = 0;
                        for (int k = starIndexSum; k < i; k++)
                        {
                            sum += elementsArray[k];
                        }
                        elementsArray[i] = sum;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", elementsArray));
        }
    }
}
