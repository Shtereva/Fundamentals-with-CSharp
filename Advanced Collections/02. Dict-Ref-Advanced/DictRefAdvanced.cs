using System;
using System.Collections.Generic;
using System.Linq;

class DictRefAdvanced
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var reference = new Dictionary<string, List<int>>();

        while (input[0] != "end")
        {
            var text = input[0].Trim();
            input[1].Trim();
            var numberToString = input[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            bool parsed = true;
            parsed = TryingToParseValues(numberToString, parsed);
            if (parsed)
            {
                AddingElementsToDictionary(reference, text, numberToString);

            }

            else
            {
                if (reference.ContainsKey(numberToString[0]))
                {
                    ReplaceOldValueWithNewOne(reference, text, numberToString);
                }

                else
                {
                    input = Console.ReadLine().Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    continue;
                }
            }

            input = Console.ReadLine().Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        foreach (var item in reference)
        {
            Console.WriteLine($"{item.Key} === {string.Join(", ", item.Value)}");
        }
    }

    private static void ReplaceOldValueWithNewOne(Dictionary<string, List<int>> reference, string text, string[] numberToString)
    {

        if (!reference.ContainsKey(text))
        {
            reference[text] = new List<int>();
        }

        var key = reference[numberToString[0]].ToArray();

        for (int i = 0; i < key.Length; i++)
        {
            reference[text].Add(key[i]);
        }
    }

    private static bool TryingToParseValues(string[] numberToString, bool parsed)
    {
        for (int i = 0; i < numberToString.Length; i++)
        {
            int num = 0;
            parsed = int.TryParse(numberToString[i], out num);
            if (parsed == false)
            {
                break;
            }
        }

        return parsed;
    }

    private static void AddingElementsToDictionary(Dictionary<string, List<int>> reference, string text, string[] numberToString)
    {
        if (!reference.ContainsKey(text))
        {
            reference[text] = new List<int>();
        }

        for (int i = 0; i < numberToString.Length; i++)
        {
            reference[text].Add(int.Parse(numberToString[i]));
        }
    }
}
