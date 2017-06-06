using System;
using System.Collections.Generic;
using System.Linq;
class LambadaExpressions
{
    static void Main()
    {
        string input = Console.ReadLine();
        var dict = new Dictionary<string, List<string>>();

        string property = string.Empty;
        string selectorObject = string.Empty;
        string selector = string.Empty;

        while (input != "lambada")
        {
            if (input == "dance")
            {
                foreach (var item in dict)
                {
                    dict[item.Key].Insert(0, item.Value[0]);
                }

                input = Console.ReadLine();
                continue;
            }

            var line = input.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
            selector = line[0];
            selectorObject = line[1];
            property = line[2];
            AddingExpressionsToDictionary(dict, property, selector, selectorObject);
            input = Console.ReadLine();
        }


        foreach (var item in dict)
        {
            //var rightPart = item.Value.ToList();

            Console.WriteLine($"{item.Key} => {string.Join(".", item.Value)}");
        }
    }

    private static void AddingExpressionsToDictionary(Dictionary<string, List<string>> dict, string property, string selector, string selectorObject)
    {
        if (!dict.ContainsKey(selector))
        {
            dict[selector] = new List<string>();
        }

        if (dict[selector].Contains(selectorObject))
        {
            dict[selector].RemoveAt(dict[selector].Count - 1);
        }

        else
        {
            dict[selector].Add(selectorObject);
        }
        dict[selector].Add(property);
    }
}
