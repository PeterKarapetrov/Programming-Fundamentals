using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            List<int> len = new List<int>();
            len.Add(numbersList[0]);

            List<List<int>> lis = new List<List<int>>();
            lis.Add(len);
            int maxLenght = 1;

            
                for (int i = 1; i < numbersList.Count; i++)
                {
                    int num = numbersList[i];

                    for (int j = lis.Count - 1; j >= 0; j--)
                    {
                        int lastDigit = lis[j].Last();
                        if (lastDigit < num)
                        {
                            int[] array = new int[lis[j].Count];
                            lis[j].CopyTo(array);
                            List<int> newList = array.ToList();
                            newList.Add(num);
                            lis.Add(newList);
                            maxLenght = lis.Count;
                            break;
                        }
                        else if (num == lastDigit)
                        {
                            lis[j].RemoveAt(lis[j].Count - 1);
                            lis[j].Add(num);
                            break;
                        }
                        else if (num < lastDigit && lis[j].Count == 1)
                        {
                            lis[j].RemoveAt(lis[j].Count - 1);
                            lis[j].Add(num);
                            break;
                        }
                        else if (num < lastDigit && num > lis[j].ElementAt(lis[j].Count - 2))
                        {
                            lis[j].RemoveAt(lis[j].Count - 1);
                            lis[j].Add(num);
                            break;
                        }
                    }
                }
            Console.WriteLine(string.Join(" ", lis[maxLenght - 1]));
        }
    }
}
