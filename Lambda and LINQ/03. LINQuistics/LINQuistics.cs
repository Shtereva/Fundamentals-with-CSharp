using System;
using System.Collections.Generic;
using System.Linq;
class LINQuistics
{
    static void Main()
    {
        var input = Console.ReadLine();
        var dictionary = new Dictionary<string, List<string>>();

        while (input != "exit")
        {
            var line = input.Split(new[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            string collection = line[0];

            if (line.Length == 1)
            {
                int digit = 0;

                if (dictionary.ContainsKey(collection))
                {
                    PrintFirstResult(dictionary, collection);
                }

                if (int.TryParse(collection, out digit))
                {
                    if (dictionary.Keys.Count > 0)
                    {
                        PrintIfInputIsDigit(dictionary, digit);
                    }

                }
                input = Console.ReadLine();
                continue;
            }

            AddElementToDictionary(dictionary, line, collection);

            input = Console.ReadLine();
        }

        var finalLine = Console.ReadLine().Split();

        dictionary = dictionary
            .Where(x => x.Value.Contains(finalLine[0]))
            .OrderByDescending(count => count.Value.Count())
            .ThenByDescending(len => len.Value.Min(x => x.Length))
            .ToDictionary(x => x.Key, x => x.Value);

        PrintFinalResult(dictionary, finalLine);
    }

    private static void PrintIfInputIsDigit(Dictionary<string, List<string>> dictionary, int digit)
    {
        var result = dictionary
                    .OrderByDescending(count => count.Value.Count())
                    .ToDictionary(x => x.Key, x => x.Value
                        .OrderBy(len => len.Length)
                        .Take(digit)
                        .Select(item => $"* {item}")
                        .ToList());

        result.Values
            .First()
            .ToList()
            .ForEach(Console.WriteLine);
    }

    private static void PrintFinalResult(Dictionary<string, List<string>> dictionary, string[] finalLine)
    {
        if (finalLine[1] == "collection")
        {
            dictionary
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key}"));
        }

        else
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                item.Value
                    .OrderByDescending(x => x.Length)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"* {x}"));
            }
        }
    }

    private static void PrintFirstResult(Dictionary<string, List<string>> dictionary, string collection)
    {
        var result = dictionary[collection]
                                 .OrderByDescending(len => len.Length)
                                 .ThenByDescending(symb => symb.ToCharArray().Distinct().Count())
                                 .Select(x => $"* {x}")
                                 .ToList();

        result.ToList().ForEach(Console.WriteLine);
    }

    private static void AddElementToDictionary(Dictionary<string, List<string>> dictionary, string[] line, string collection)
    {
        if (!dictionary.ContainsKey(collection))
        {
            dictionary[collection] = new List<string>();
        }

        for (int i = 1; i < line.Length; i++)
        {
            if (!dictionary[collection].Contains(line[i]))
            {
                dictionary[collection].Add(line[i]);
            }
        }
    }
}
