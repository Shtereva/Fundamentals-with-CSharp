using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.Match_Numbers
{
    class MatchNumbers
    {
        static void Main()
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var text = Console.ReadLine();
            var matches = Regex.Matches(text, regex)
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
