using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Match_Dates
{
    class MatchDates
    {
        static void Main()
        {
            var regex = @"\b(?<day>\d{2})(?<sep>[\.\-\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";

            var dates = Console.ReadLine();
            var matches = Regex.Matches(dates, regex);

            foreach (Match match in matches)
            {
                var day = match.Groups["day"];
                var month = match.Groups["month"];
                var year = match.Groups["year"];

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
