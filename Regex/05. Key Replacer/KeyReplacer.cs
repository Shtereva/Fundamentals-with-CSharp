using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.Key_Replacer
{
    class KeyReplacer
    {
        static void Main()
        {
            string input1 = Console.ReadLine();
            var regex = new Regex(@"^(?<start>\w+)[<\|\\][\w\|]+\|(?<end>\w+)$");
            var keys = regex.Match(input1);

            string start = keys.Groups["start"].Value;
            string end = keys.Groups["end"].Value;

            var input2 = Console.ReadLine();
            var regexBetween = new Regex(start + @"(?<textBetween>[\w]{0,}?)" + end);

            var matches = regexBetween.Matches(input2)
                .Cast<Match>()
                .ToList();

            var result = new List<string>();
            
            foreach (var match in matches)
            {
                result.Add(match.Groups[1].Value);
            }

            Console.WriteLine(result.All(x => x == "") ? "Empty result" : $"{string.Join("", result)}");


        }
    }
}
