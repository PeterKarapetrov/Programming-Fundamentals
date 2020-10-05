using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> usersLogDD = new SortedDictionary<string, Dictionary<string, int>>();

            List<string> fullLogList = Console.ReadLine()
                                       .Split()
                                       .ToList();

            

            while (fullLogList[0] != "end")
            {
                string[] userNameArr = fullLogList[2].Split('=').Skip(1).ToArray();
                string userName = userNameArr[0];
                string[] ipStr = fullLogList[0].Split('=').Skip(1).ToArray();
                string ip = ipStr[0];

                Dictionary<string, int> ipDict = new Dictionary<string, int>();

                if (usersLogDD.ContainsKey(userName) == false)
                {
                    ipDict.Add(ip, 1);
                    usersLogDD.Add(userName, ipDict);
                }
                else
                {
                    if (usersLogDD[userName].ContainsKey(ip) == false)
                    {
                        usersLogDD[userName].Add(ip, 1);
                    }
                    else
                    {
                        usersLogDD[userName][ip]++;
                    }
                }

                fullLogList = Console.ReadLine()
                                       .Split()
                                       .ToList();
            }
            string resultString = null;
            foreach (var pair in usersLogDD)
            {
                Console.WriteLine($"{pair.Key}:");
                foreach (var ipPair in pair.Value)
                {
                    resultString += $"{ipPair.Key} => {ipPair.Value}, ";
                }
                resultString = resultString.Remove(resultString.Length - 2, 2);
                Console.WriteLine(resultString + ".");
                resultString = null;
            }
            
        }
    }
}
