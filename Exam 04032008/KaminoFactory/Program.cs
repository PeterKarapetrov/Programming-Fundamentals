using System;
using System.Collections.Generic;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)

        {
            int dnaLenght = int.Parse(Console.ReadLine());
            string inputLine = Console.ReadLine();
            int bestDNAStartingIndex = int.MinValue;
            int bestDNASubLenght = int.MinValue;
            int bestDNASum = int.MinValue;
            int bestDNASample = 0;
            int dnaSample = 1;
            List<int> bestDNA = new List<int>();

            while (inputLine != "Clone them!")
            {
                int[] dnaArray = inputLine.Split(new[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (dnaArray.Length != dnaLenght)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                int dnaSum = 0;
                for (int i = 0; i < dnaArray.Length; i++)
                {
                    if (dnaArray[i] == 1)
                    {
                        dnaSum++;
                    }
                }

                if (dnaSum == 1 && dnaLenght == 1)
                {
                    bestDNASample = dnaSample;
                    bestDNASum = 1;
                    bestDNA.Clear();
                    bestDNA = dnaArray.ToList();
                }

                int seqLenght = 1;

                for (int i = 0; i < dnaArray.Length - 1; i++)
                {
                    
                    if (dnaArray[i] == dnaArray[i+1] && dnaArray[i] == 1 && dnaArray[i+1] == 1)
                    {
                        seqLenght++;
                    }
                    else
                    {
                        seqLenght = 1;
                    }

                    if (seqLenght > bestDNASubLenght)
                    {
                        bestDNAStartingIndex = i;
                        bestDNASubLenght = seqLenght;
                        bestDNASample = dnaSample;
                        bestDNASum = dnaSum;
                        bestDNA.Clear();
                        bestDNA = dnaArray.ToList();
                    }
                    else if (seqLenght == bestDNASubLenght )
                    {
                        if (i < bestDNAStartingIndex)
                        {
                            bestDNAStartingIndex = i;
                            bestDNASubLenght = seqLenght;
                            bestDNASample = dnaSample;
                            bestDNASum = dnaSum;
                            bestDNA.Clear();
                            bestDNA = dnaArray.ToList();
                        }
                        else if (i == bestDNAStartingIndex)
                        {
                            if (dnaSum > bestDNASum)
                            {
                                bestDNAStartingIndex = i;
                                bestDNASubLenght = seqLenght;
                                bestDNASample = dnaSample;
                                bestDNASum = dnaSum;
                                bestDNA.Clear();
                                bestDNA = dnaArray.ToList();
                            }
                        }
                    }
                }
                inputLine = Console.ReadLine();
                dnaSample++;
            }
            if (bestDNASum < 0)
            {
                return;
            }
            Console.WriteLine($"Best DNA sample {bestDNASample} with sum: {bestDNASum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
