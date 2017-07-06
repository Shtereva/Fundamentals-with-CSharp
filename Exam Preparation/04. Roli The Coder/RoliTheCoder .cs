using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Roli_The_Coder
{
    public class Event
    {
        public string Name { get; set; }
        public List<string> Participians { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var events = new Dictionary<string, Event>();

            string input = Console.ReadLine();

            while (input != "Time for Code")
            {
                var idAndGroup = Regex.Match(input, @"(?<id>\d+)\s+#(?<event>\w+)\s*");

                if (idAndGroup.Success)
                {
                    var participians = Regex.Matches(input, @"@[A-Za-z0-9'-]+(?=$|\s+)")
                        .Cast<Match>()
                        .Select(x => x.Value)
                        .ToList();

                    if (!events.ContainsKey(idAndGroup.Groups["id"].Value))
                    {
                        events[idAndGroup.Groups["id"].Value] = new Event()
                        {
                            Name = idAndGroup.Groups["event"].Value,
                            Participians = new List<string>()
                        };
                    }

                    if (idAndGroup.Groups["event"].Value == events[idAndGroup.Groups["id"].Value].Name)
                    {
                        events[idAndGroup.Groups["id"].Value].Participians.AddRange(participians);
                        events[idAndGroup.Groups["id"].Value].Participians = events[idAndGroup.Groups["id"].Value]
                            .Participians.Distinct().ToList();
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var @event in events.Values
                                                .OrderByDescending(x => x.Participians.Count)
                                                .ThenBy(x => x.Name))
            {
                Console.WriteLine($"{@event.Name} - {@event.Participians.Count}");

                @event.Participians
                    .OrderBy(x => x)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
        }
    }
}
