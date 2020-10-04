using System;
using System.Collections.Generic;
using System.Linq;

namespace LIS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            if (numList.Length == 1)
            {
                Console.WriteLine(numList[0]);
                return;
            }


            int[] len = new int[numList.Length];

            for (int numIndex = 0; numIndex < numList.Length; numIndex++)
            {
                len[numIndex] = 1;
                for (int i = 0; i <= numIndex - 1 ; i++)
                {
                    if (numList[i] < numList[numIndex] && len[i] + 1 > len[numIndex])
                    {
                        len[numIndex] = 1 + len[i];
                    }
                }
            }

            int maxLenght = 0;
            int lastIndex = -1;
            int[] prev = new int[numList.Length];
            for (int x = 0; x < numList.Length; x++)
            {
                len[x] = 1;
                prev[x] = -1;
                for (int i = 0; i < x; i++)
                {
                    if ((numList[i] < numList[x]) && (len[i] + 1 > len[x]))
                    {
                        len[x] = len[i] + 1;
                        prev[x] = i;
                    }
                    if (len[x] > maxLenght)
                    {
                        maxLenght = len[x];
                        lastIndex = x;
                    }
                }

            }

            Console.WriteLine(string.Join(" ", ReturnResultArray(numList, prev, lastIndex)));
           
        }
        
        static List<int> ReturnResultArray(int[] numList, int[] prev, int lastIndex)
        {
            List<int> resultSeq = new List<int>();
            while (lastIndex != -1)
            {
                resultSeq.Add(numList[lastIndex]);
                lastIndex = prev[lastIndex];
            }

            resultSeq.Reverse();
            return resultSeq;
        }
    }
}
