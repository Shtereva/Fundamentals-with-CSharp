using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Regexmon
{
    class Regexmon
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var didimon = @"[^A-Za-z-]+";
            var bojoman = @"[A-Za-z]+-[A-Za-z]+";
            var result = new StringBuilder();

            int count = 1;

            while (true)
            {
                if (count % 2 != 0)
                {
                    var match = Regex.Match(input, didimon);
                    if (!match.Success)
                    {
                        break;
                    }

                    result.AppendLine(match.Value);
                    var index = input.IndexOf(match.Value);
                    input = input.Remove(0, index + match.Value.Length);
                    count++;
                }

                else
                {
                    var match = Regex.Match(input, bojoman);
                    if (!match.Success)
                    {
                        break;
                    }

                    result.AppendLine(match.Value);
                    var index = input.IndexOf(match.Value);
                    input = input.Remove(0, index + match.Value.Length);
                    count++;
                }
            }

            Console.Write(result.ToString());
        }
    }
}
