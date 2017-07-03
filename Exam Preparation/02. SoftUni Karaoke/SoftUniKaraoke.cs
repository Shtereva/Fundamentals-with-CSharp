using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.SoftUni_Karaoke
{
    class SoftUniKaraoke
    {
        static void Main()
        {
            var participants = Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var songs = Console.ReadLine()
                .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            string stagePerformance = Console.ReadLine();

            var awards = new Dictionary<string, List<string>>();

            while (stagePerformance != "dawn")
            {
                var line = stagePerformance
                    .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                string participant = line[0];
                string song = line[1];
                string award = line[2];

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!awards.ContainsKey(participant))
                    {
                        awards[participant] = new List<string>();
                    }

                    awards[participant].Add(award);
                }

                stagePerformance = Console.ReadLine();
            }

            PrintAwards(awards);
        }

        private static void PrintAwards(Dictionary<string, List<string>> awards)
        {
            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            else
            {
                foreach (var member in awards
                                        .OrderByDescending(x => x.Value.Distinct().Count())
                                        .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{member.Key}: {member.Value.Distinct().Count()} awards");

                    member.Value
                        .Distinct()
                        .OrderBy(x => x)
                        .ToList()
                        .ForEach(x => Console.WriteLine($"--{x}"));
                }

            }
        }
    }
}
