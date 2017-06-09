using System;
using System.Collections.Generic;
using System.Linq;
class UserLogs
{
    static void Main()
    {
        string input = Console.ReadLine();
        var users = new SortedDictionary<string, Dictionary<string, int>>();

        while (input != "end")
        {
            var line = input.Split("= ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var addressIP = line[1];
            var name = line[5];

            if (!users.ContainsKey(name))
            {
                users[name] = new Dictionary<string, int>();
            }

            if (!users[name].ContainsKey(addressIP))
            {
                users[name][addressIP] = 0;
            }

            users[name][addressIP]++;

            input = Console.ReadLine();
        }

        foreach (var name in users)
        {
            Console.WriteLine(name.Key + ":");

            var result = name.Value
                .Select(x => $"{x.Key} => {x.Value}")
                .ToList();

            Console.WriteLine(string.Join(", ", result) + ".");
        }
    }
}
