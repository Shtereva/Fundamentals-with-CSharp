using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class LegendaryFarming
{
    static void Main()
    {
        var items = new SortedDictionary<string, int>();
        items["shards"] = 0;
        items["fragments"] = 0;
        items["motes"] = 0;

        bool hasMatch = true;

        while (hasMatch)
        {
            var input = Console.ReadLine().ToLower().Split();

            for (int i = 1; i <= input.Length; i += 2)
            {
                if (!items.ContainsKey(input[i]))
                {
                    items[input[i]] = 0;
                }

                items[input[i]] += int.Parse(input[i - 1]);

                if (items["shards"] >= 250 || items["fragments"] >= 250 || items["motes"] >= 250)
                {
                    var dict = new Dictionary<string, string>();
                    dict["shards"] = "Shadowmourne";
                    dict["fragments"] = "Valanyr";
                    dict["motes"] = "Dragonwrath";
                    Console.WriteLine(dict[input[i]] + " obtained!");
                    items[input[i]] -= 250;
                    hasMatch = false;
                    break;
                }
            }
        }
        PrintResult(items);
    }

    private static void PrintResult(SortedDictionary<string, int> items)
    {
        var result = items
                .Where(item => item.Key == "shards" || item.Key == "fragments" || item.Key == "motes")
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(x => $"{x.Key}: {x.Value}")
                .ToList();
                
        Console.WriteLine(string.Join(Environment.NewLine, result));

        items
            .Where(x => !(x.Key == "shards" || x.Key == "fragments" || x.Key == "motes"))
            .OrderBy(x => x.Key)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.Key}: {x.Value}"));

    }
}
