using System;
using System.Collections.Generic;
using System.Linq;
class LambadaExpressions
{
    static void Main()
    {
        string input = Console.ReadLine();
        var dict = new Dictionary<string, List<string>>();

        string previousProperty = string.Empty;
        string previousObject = string.Empty;
        string previousSelector = string.Empty;
        while (input != "lambada")
        {
            if (input == "dance")
            {
                dict[previousSelector].Add(previousObject + ".");
                input = Console.ReadLine();
                continue;
            }

            var line = input.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string selector = line[0];
            string selectorObject = line[1];
            string property = line[2];
            AddingExpressionsToDictionary(dict, previousProperty, selector, selectorObject, property);

            previousProperty = property;
            previousObject = selectorObject;
            previousSelector = selector;

            input = Console.ReadLine();
        }

        foreach (var item in dict)
        {
            Console.Write($"{item.Key} => ");

           // var rightPart = item.Value
                //.OrderBy()
                //.to
        }
    }

    private static void AddingExpressionsToDictionary(Dictionary<string, List<string>> dict, string previousProperty, string selector, string selectorObject, string property)
    {
        if (!dict.ContainsKey(selector))
        {
            dict[selector] = new List<string>();
        }

        if (dict[selector].Contains(selectorObject + "."))
        {
            dict[selector].Remove(previousProperty);
        }

        else
        {
            dict[selector].Add(selectorObject + ".");
        }
        dict[selector].Add(property);
    }
}
