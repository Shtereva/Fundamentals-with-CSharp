using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Rage_Quit
{
    class RageQuit
    {
        static void Main()
        {
            var input = Console.ReadLine().ToUpper();

            var matches = Regex.Matches(input, @"(?<symbols>\D+)(?<digits>\d+)*");
            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                var symbols = match.Groups["symbols"].Value;
                var digits = 0;
                var parsed = int.TryParse(match.Groups["digits"].Value, out digits);
                

                for (int i = 0; i < digits; i++)
                {
                    result.Append(symbols);
                }
            }

            var uniqueSymbols = result.ToString().ToCharArray().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(result.ToString());
        }
    }
}
