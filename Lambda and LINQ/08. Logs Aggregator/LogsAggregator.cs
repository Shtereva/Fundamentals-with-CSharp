using System;
using System.Collections.Generic;
using System.Linq;
class LogsAggregator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var logs = new SortedDictionary<string, SortedDictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            string name = input[1];
            string addressIP = input[0];
            int duration = int.Parse(input[2]);

            AddDataToLogs(logs, name, addressIP, duration);
        }

        foreach (var name in logs)
        {
            Console.Write($"{name.Key}: {name.Value.Sum(x => x.Value)} ");

          var result =  name.Value
                .Select(x => x.Key)
                .Distinct()
                .ToList();

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }

    private static void AddDataToLogs(SortedDictionary<string, SortedDictionary<string, int>> logs, string name, string addressIP, int duration)
    {
        if (!logs.ContainsKey(name))
        {
            logs[name] = new SortedDictionary<string, int>();
        }

        if (!logs[name].ContainsKey(addressIP))
        {
            logs[name][addressIP] = 0;
        }

        logs[name][addressIP] += duration;
    }
}
