using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            string firstPattern = @"( \| )";
            string secondPattern = @"( -> )";

            string inputLine = Console.ReadLine();

            while (inputLine != "Lumpawaroo")
            {
                if (Regex.IsMatch(inputLine, firstPattern))
                {
                    string[] userInfo = Regex.Split(inputLine, firstPattern);
                    string user = userInfo[2];
                    string userSide = userInfo[0];
                    if (users.ContainsKey(user) == false)
                    {
                        users.Add(user, userSide);
                    }
                }
                else if (Regex.IsMatch(inputLine, secondPattern))
                {
                    string[] userInfo = Regex.Split(inputLine, secondPattern);
                    string user = userInfo[0];
                    string userSide = userInfo[2];
                    if (users.ContainsKey(user) == false)
                    {
                        users.Add(user, userSide);
                        Console.WriteLine($"{user} joins the {userSide} side!");
                    }
                    else
                    {
                        users[user] = userSide;
                        Console.WriteLine($"{user} joins the {userSide} side!");
                    }
                }
                inputLine = Console.ReadLine();
            }
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            foreach (var user in users)                
            {
                if (sides.ContainsKey(user.Value) == false)
                {
                    List<string> newList = new List<string>();
                    newList.Add(user.Key);
                    sides.Add(user.Value, newList);
                }
                else
                {
                    sides[user.Value].Add(user.Key);
                }
            }

            foreach (var side in sides.OrderByDescending(x => x.Value.Count).ThenBy(n => n.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
