using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Match_Hexadecimal_Numbers
{
    class MatchHexadecimalNumbers
    {
        static void Main()
        {
            var regex = @"\b(?:0x)?[A-F0-9]+\b";

            var text = Console.ReadLine();

            var matches = Regex.Matches(text, regex);

            var result = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
