using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class СръбскоUnleashed
{
    static void Main()
    {
        string input = Console.ReadLine();
        var statistics = new Dictionary<string, Dictionary<string, long>>();

        while (input != "End")
        {
            var line = input.Split().ToList();

            int ticketCount = 0;
            bool parsedOne = int.TryParse(line[line.Count - 1], out ticketCount);

            int ticketPrice = 0;
            bool parsedTwo = int.TryParse(line[line.Count - 2], out ticketPrice);

            if (line.Count < 4 || !input.ToCharArray().Contains('@'))
            {
                input = Console.ReadLine();
                continue;
            }

            line.RemoveRange(line.Count - 2, 2);

            if (parsedOne == false || parsedTwo == false)
            {
                input = Console.ReadLine();
                continue;
            }
            line = string.Join(" ", line).Split('@').ToList();

            string name = line[0].Trim();

            // line = line[1].Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            string venue = string.Join(" ", line[1]);

            if (!statistics.ContainsKey(venue))
            {
                statistics[venue] = new Dictionary<string, long>();
            }

            if (!statistics[venue].ContainsKey(name))
            {
                statistics[venue][name] = 0;
            }

            statistics[venue][name] += ticketCount * ticketPrice;

            input = Console.ReadLine();
        }

        foreach (var venue in statistics)
        {
            Console.WriteLine(venue.Key);

            venue.Value
                .OrderByDescending(x => x.Value)
                .ToList()
                .ForEach(x => Console.WriteLine($"#  {x.Key} -> {x.Value}"));
        }
    }
}
