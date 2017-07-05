using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Mines
{
    class Mines
    {
        static void Main()
        {
            string mines = Console.ReadLine();
            int lenght = mines.Length;
            var matches = Regex.Matches(mines, @"<(?<mine>.{2})>");

            foreach (Match match in matches)
            {
                var firstIndex = mines.IndexOf(match.Value);
                var lastIndex = firstIndex + 3;

                var sum = Math.Abs(match.Groups["mine"].Value[0] - match.Groups["mine"].Value[1]);

                int start = Math.Max(firstIndex - sum, 0);
                int count = Math.Min((lastIndex + 1 + sum) - start, mines.Length - start);
                var subString = mines.Substring(start, count);
                mines = Regex.Replace(mines, subString, new string('_', subString.Length));

            }

            Console.WriteLine(mines);
        }
    }
}
