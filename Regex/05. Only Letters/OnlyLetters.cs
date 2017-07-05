using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.Only_Letters
{
    class OnlyLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var matches = Regex.Matches(input, @"(?<digits>\d+)(?<letter>[A-Za-z]{0,1})");

            foreach (Match match in matches)
            {
                var digits = match.Groups["digits"].Value;
                var letter = match.Groups["letter"].Value;

                if (letter.Length > 0)
                {
                    input = Regex.Replace(input, digits, letter);
                }
            }

            Console.WriteLine(input);
        }
    }
}
