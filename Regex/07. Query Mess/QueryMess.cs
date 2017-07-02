using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07_QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, string>();

            while (input != "END")
            {
                input = input.Replace("%20", " ");
                input = input.Replace("+", " ");

                input = Regex.Replace(input, @"\s+", " ");
                var pattern = @"\s*(?<field>[a-z]+)\s*=(?<value>.*?)(&|$)";

                var matchedQueries = Regex.Matches(input, pattern);

                foreach (Match query in matchedQueries)
                {
                    var field = query.Groups["field"].Value;
                    var value = query.Groups["value"].Value;

                    if (!result.ContainsKey(field))
                    {
                        result[field] = string.Empty;
                        result[field] = value;
                    }
                    else
                    {
                        result[field] += ", " + value;
                    }

                }

                result = result.ToDictionary(x => x.Key.Trim(), x => x.Value);

                foreach (var kvp in result)
                {
                    string key = kvp.Key.Trim();
                    string value = kvp.Value.Trim();

                    Console.Write($"{key}=[{value}]");
                }
                Console.WriteLine();

                result = new Dictionary<string, string>();
                input = Console.ReadLine();
            }
        }
    }
}