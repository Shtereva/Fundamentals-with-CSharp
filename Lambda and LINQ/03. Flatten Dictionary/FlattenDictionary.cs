using System;
using System.Collections.Generic;
using System.Linq;
class FlattenDictionary
{
    static void Main()
    {
        string input = Console.ReadLine();
        var dictionary = new Dictionary<string, Dictionary<string, string>>();
        var flattered = new Dictionary<string, string>();
        string key = string.Empty;

        while (input != "end")
        {
            var line = input.Split(' ');
            if (line.Contains("flatten"))
            {
                input = FlatteningKey(dictionary, flattered, line, ref key);
                continue;
            }
            string device = line[0];
            string brand = line[1];
            string model = line[2];

            if (!dictionary.ContainsKey(device))
            {
                dictionary[device] = new Dictionary<string, string>();

            }

            dictionary[device][brand] = model;

            input = Console.ReadLine();
        }

        var orderKeys = dictionary
            .OrderByDescending(x => x.Key.Length)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var mainKey in orderKeys)
        {
            Console.WriteLine(mainKey.Key);
            var orderInnerKeys = mainKey.Value
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

            if (mainKey.Key == key)
            {
               orderInnerKeys = orderInnerKeys.Concat(flattered).ToDictionary(x => x.Key, x => x.Value);
            }

            int count = 1;
            foreach (var kvp in orderInnerKeys)
            {
                Console.WriteLine(kvp.Value != string.Empty ? $"{count}. {kvp.Key} - {kvp.Value}" : $"{count}. {kvp.Key}");
                count++;
            }
        }

    }


    private static string FlatteningKey(Dictionary<string, Dictionary<string, string>> dictionary, Dictionary<string, string> flattered, string[] line, ref string key)
    {
        string input;
        key = line[1];
        var keysToRemove = new List<string>();
        foreach (var item in dictionary[key])
        {
            keysToRemove.Add(item.Key);
            if (!flattered.ContainsKey(item.Key + item.Value))
            {
                flattered[item.Key + item.Value] = string.Empty;
            }
        }

        foreach (var item in keysToRemove)
        {
            dictionary[key].Remove(item);
        }

        input = Console.ReadLine();
        return input;
    }
}
