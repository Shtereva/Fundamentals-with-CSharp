using System;
using System.Collections.Generic;
using System.Linq;

class AMinerTask
{
    static void Main()
    {
        string input = Console.ReadLine();
        var resources = new Dictionary<string, long>();
        string lastInput = string.Empty;

        for (int i = 1; i < int.MaxValue; i++)
        {
            if (input == "stop")
            {
                break;
            }

            AddResources(ref input, resources, ref lastInput, i);
            input = Console.ReadLine();
        }

        foreach (var item in resources)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }

    private static void AddResources(ref string input, Dictionary<string, long> resources, ref string lastInput, int i)
    {
        if (i % 2 != 0)
        {
            if (!resources.ContainsKey(input))
            {
                resources[input] = 0;
                lastInput = input;
            }
            else
            {
                lastInput = input;
            }
        }

        else
        {
            resources[lastInput] += int.Parse(input);
        }

    }
}
