using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    class ValidUsernames
    {
        static void Main()
        {
            var usernames = Regex.Matches(Console.ReadLine(), @"(?<=[\s\\\/()]|^)[A-Za-z]\w{2,24}(?=[\s\\\/()]|$)")
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();

            int maxLen = 0;
            var result = new string[2];

            for (int i = 0; i < usernames.Length - 1; i++)
            {
                int len = usernames[i].Length + usernames[i + 1].Length;

                if (len > maxLen)
                {
                    maxLen = len;
                    result[0] = usernames[i];
                    result[1] = usernames[i + 1];
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
