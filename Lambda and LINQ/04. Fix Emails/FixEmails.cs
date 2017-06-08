using System;
using System.Collections.Generic;
using System.Linq;

class AMinerTask
{
    static void Main()
    {
        string input = Console.ReadLine();
        var emails = new Dictionary<string, string>();
        string lastInput = string.Empty;

        for (int i = 1; i < int.MaxValue; i++)
        {
            if (input == "stop")
            {
                break;
            }

            AddResources(ref input, emails, ref lastInput, i);
            input = Console.ReadLine();
        }

        foreach (var item in emails)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }

    private static void AddResources(ref string input, Dictionary<string, string> emails, ref string lastInput, int i)
    {
        if (i % 2 != 0)
        {
            if (!emails.ContainsKey(input))
            {
                emails[input] = string.Empty;
                lastInput = input;
            }
            else
            {
                lastInput = input;
            }
        }

        else
        {
            emails[lastInput] = input;
        }

        if (input.EndsWith("us") || input.EndsWith("uk"))
        {
            emails.Remove(lastInput);
        }
    }
}
