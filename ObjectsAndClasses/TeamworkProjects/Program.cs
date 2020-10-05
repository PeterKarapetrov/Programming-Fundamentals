using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> teams = new Dictionary<string, string>();
            int teamCount = int.Parse(Console.ReadLine());
            
            for (int count = 0; count < teamCount; count++)
            {
                string[] inputLine = Console.ReadLine().Split('-').ToArray();
                string user = inputLine[0];
                string team = inputLine[1];
                if (teams.ContainsKey(team) == true)
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (teams.ContainsValue(user) == true)
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
                else
                {
                    teams.Add(team, user);
                    Console.WriteLine($"Team {team} has been created by {user}!");
                }
            }

            Dictionary<string, List<string>> teamList = new Dictionary<string, List<string>>();

            foreach (var pair in teams)
            {
                List<string> membersList = new List<string>() { pair.Value };
                teamList.Add(pair.Key, membersList);
            }

            string membersInput = Console.ReadLine();

            while (membersInput != "end of assignment")
            {
                string[] teamChoice = membersInput.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = teamChoice[0];
                string team = teamChoice[1];

                if (teams.ContainsKey(team) == false)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    membersInput = Console.ReadLine();
                    continue;
                }             

                foreach (var pair in teamList)
                {
                    if (pair.Value.Contains(user) == true)
                    {
                        Console.WriteLine($"Member {user} cannot join team {pair.Key}!");
                        break;
                    }
                    else if (pair.Key == team)
                    {
                        pair.Value.Add(user);
                    }
                }

                membersInput = Console.ReadLine();
            }

            foreach (var team in teamList.Where(t => t.Value.Count > 1).
            OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{team.Key}");
                foreach (var member in team.Value.Take(1))
                {
                    Console.WriteLine($"- {member}");
                }
                foreach (var member in team.Value.Skip(1).OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");

            foreach (var team in teamList.Where(x => x.Value.Count == 1).OrderBy(y => y.Key))
            {
                Console.WriteLine($"{team.Key}");
            }
        }
    }
}
