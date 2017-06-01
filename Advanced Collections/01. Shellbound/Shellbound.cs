using System;
using System.Collections.Generic;
using System.Linq;

class Shellbound
{
    static void Main()
    {
        var line = Console.ReadLine().Split();
        var shellbound = new Dictionary<string, List<int>>();

        while (line[0] != "Aggregate")
        {
            string region = line[0];
            int size = int.Parse(line[1]);
            AddregionsToShellBound(shellbound, region, size);
            line = Console.ReadLine().Split();
        }

        PrintResult(shellbound);
    }

    private static void PrintResult(Dictionary<string, List<int>> shellbound)
    {
        foreach (var region in shellbound)
        {
            var avg = region.Value.Sum() - region.Value.Average();
            Console.WriteLine($"{region.Key} -> {string.Join(", ", region.Value)} ({avg:f0})");
        }
    }

    private static void AddregionsToShellBound(Dictionary<string, List<int>> shellbound, string region, int size)
    {
        if (!shellbound.ContainsKey(region))
        {
            shellbound[region] = new List<int>();
        }

        if (!shellbound[region].Contains(size))
        {
            shellbound[region].Add(size);

        }
    }
}
