using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAgregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> logsDD = new Dictionary<string, Dictionary<string, int>>();

            int logFilesCount = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < logFilesCount; counter++)
            {
                List<string> inputLine = Console.ReadLine()
                                    .Split()
                                    .ToList();

                string user = inputLine[1];
                string userIP = inputLine[0];
                int sessionTime = int.Parse(inputLine[2]);

                if (logsDD.ContainsKey(user) == false)
                {
                    Dictionary<string, int> session = new Dictionary<string, int>();
                    session.Add(userIP, sessionTime);
                    logsDD[user] = session;
                }
                else
                {
                    if (logsDD[user].ContainsKey(userIP) == false)
                    {
                        logsDD[user].Add(userIP, sessionTime);
                    }
                    else
                    {
                        logsDD[user][userIP] += sessionTime;
                    }
                }
            }

            foreach (var log in logsDD.OrderBy(x => x.Key))
            {
                string resultString = null;
                Console.Write($"{log.Key}: ");
                Console.Write($"{log.Value.Values.Sum()} [" );
                foreach (var session in log.Value.OrderBy(y => y.Key))
                {
                    resultString += $"{session.Key}, ";
                }
                resultString = resultString.Remove(resultString.Length - 2, 2);
                Console.WriteLine(resultString + "]");
            }
        }
    }
}
