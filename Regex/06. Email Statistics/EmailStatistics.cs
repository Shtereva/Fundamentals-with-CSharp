using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.Email_Statistics
{
    class EmailStatistics
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var domains = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var emails = Regex.Match(Console.ReadLine(), @"(?<username>[A-Za-z]{5,})@(?<domain>[a-z]{3,}(?:\.bg|\.com|\.org))\b");

                if (emails.Success)
                {
                    if (!domains.ContainsKey(emails.Groups["domain"].Value))
                    {
                        domains[emails.Groups["domain"].Value] = new List<string>();
                    }

                    domains[emails.Groups["domain"].Value].Add(emails.Groups["username"].Value);
                }
            }

            foreach (var domain in domains.OrderByDescending(x => x.Value.Distinct().Count()))
            {
                Console.WriteLine(domain.Key + ":");
                domain.Value
                    .Distinct()
                    .ToList()
                    .ForEach(x => Console.WriteLine($"### {x}"));
            }
        }
    }
}
