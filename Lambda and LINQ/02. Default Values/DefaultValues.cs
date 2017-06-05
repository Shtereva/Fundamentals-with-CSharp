using System;
using System.Collections.Generic;
using System.Linq;
class DefaultValues
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        var values = new Dictionary<string, string>();

        while (input[0] != "end")
        {
            values[input[0]] = input[1];
            input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
        }

        string lastLine = Console.ReadLine();

        var words = values
            .Where(x => x.Value != "null")
            .OrderByDescending(x => x.Value.Length)
            .ToDictionary(x => x.Key, x => x.Value);

        var nullWords = values
            .Where(x => x.Value == "null")
            .ToDictionary(x => x.Key, x => lastLine);

        //var tempKey = new List<string>();

        //foreach (var item in nullWords.Keys)
        //{
        //    tempKey.Add(item);
        //}

        //foreach (var key in tempKey)
        //{
        //    nullWords[key] = lastLine;
        //}

        var result = words.Concat(nullWords).ToDictionary(x => x.Key, x => x.Value);

        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
        }
    }
}
