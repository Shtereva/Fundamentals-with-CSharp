using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Websites
{
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }

        public static Website Read(string input)
        {
            var line = input.Split(" |,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            return new Website
            {
                Host = line[0],
                Domain = line[1],
                Queries = line.Skip(2).ToList()
            };
        }
    }

    class Websites
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var result = new List<string>();

            while (input != "end")
            {
                var line = Website.Read(input);
                if (line.Queries.Count > 0)
                {
                    result.Add($"https://www.{line.Host}.{line.Domain}/query?=[{string.Join("]&[", line.Queries)}]");
                }

                else
                {
                    result.Add($"https://www.{line.Host}.{line.Domain}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
