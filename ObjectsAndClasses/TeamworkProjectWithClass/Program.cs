using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjectWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTeams = int.Parse(Console.ReadLine());
            List<Team> teamList = new List<Team>();

            for (int num = 0; num < numOfTeams; num++)
            {
                string[] teamsToInput = Console.ReadLine().Split('-').ToArray();
                string creator = teamsToInput[0];
                string team = teamsToInput[1];
                if (teamList.Any(x => x.Name == team))
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (teamList.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team();
                    newTeam.Name = team;
                    newTeam.Creator = creator;
                    newTeam.Members = new List<string>();
                    teamList.Add(newTeam);
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                }
            }

            string usersToJoin = Console.ReadLine();
            while (usersToJoin != "end of assignment")
            {
                string[] userChoice = usersToJoin.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = userChoice[0];
                string team = userChoice[1];
                if (teamList.Any(x => x.Name == team) == false)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teamList.Any(x => x.Creator == user) == true || teamList.Any(x => x.Members.Contains(user)) == true)
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                }
                else
                {
                    foreach (var t in teamList.Where(x => x.Name == team))
                    {
                        t.Members.Add(user);
                    }
                }

                usersToJoin = Console.ReadLine();
            }

            foreach (var team in teamList.Where(x => x.Members.Count != 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");

            foreach (var team in teamList.Where(x => x.Members.Count == 0).OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members {get; set; }

    }
}
