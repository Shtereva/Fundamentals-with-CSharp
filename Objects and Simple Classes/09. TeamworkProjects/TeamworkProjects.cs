using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    public class Team
    {
        public string TeamName { get; set; }

        public List<string> Members { get; set; }

        public string Creator { get; set; }

        public static Team Read(string[] temp)
        {
            return new Team
            {
                TeamName = temp[1],
                Creator = temp[0],
                Members = new List<string>()
            };
        }
    }

    class TeamworkProjects
    {
        static void Main()
        {
            var teams = new List<Team>();

            int num = int.Parse(Console.ReadLine());
            CreatingTeams(teams, num);

            var input = Console.ReadLine();

            while (input != "end of assignment")
            {
                var line = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string member = line[0];
                string team = line[1];
                AddMembersToTeams(teams, member, team);

                input = Console.ReadLine();
            }

            PrintTeams(teams);

            Console.WriteLine("Teams to disband:");
            teams
                .OrderBy(x => x.TeamName)
                .Where(x => x.Members.Count == 0)
                .ToList()
                .ForEach(x => Console.WriteLine(x.TeamName));
        }

        private static void PrintTeams(List<Team> teams)
        {
            foreach (var team in teams
                                .OrderByDescending(x => x.Members.Count)
                                .ThenBy(x => x.TeamName))
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine(team.TeamName);
                    Console.WriteLine($"- {team.Creator}");
                    Console.WriteLine(string.Join(Environment.NewLine, team.Members.OrderBy(x => x).Select(x => $"-- {x}")));
                }
            }
        }

        private static void AddMembersToTeams(List<Team> teams, string member, string team)
        {
            if (!teams.Any(x => x.TeamName == team))
            {
                Console.WriteLine($"Team {team} does not exist!");
            }

            else if (teams.Any(x => x.Members.Any(m => m.Contains(member))) || teams.Any(x => x.Creator == member))
            {
                Console.WriteLine($"Member {member} cannot join team {team}!");
            }

            else
            {
                var index = teams.FindIndex(x => x.TeamName == team);
                teams[index].Members.Add(member);
            }
        }

        private static void CreatingTeams(List<Team> teams, int num)
        {
            for (int i = 0; i < num; i++)
            {
                var line = Console.ReadLine().Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var temp = Team.Read(line);

                if (teams.Any(x => x.TeamName == temp.TeamName))
                {
                    Console.WriteLine($"Team {temp.TeamName} was already created!");
                }

                else if (teams.Any(x => x.Creator == temp.Creator))
                {
                    Console.WriteLine($"{temp.Creator} cannot create another team!");
                }

                else
                {
                    teams.Add(temp);
                    Console.WriteLine($"Team {temp.TeamName} has been created by {temp.Creator}!");
                }
            }
        }
    }
}
