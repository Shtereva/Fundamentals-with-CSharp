using System;
using System.Collections.Generic;
using System.Linq;
class CottageScraper
{
    static void Main()
    {
        string input = Console.ReadLine();
        var logs = new Dictionary<string, List<decimal>>();

        while (input != "chop chop")
        {
            var line = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            string woodType = line[0];
            int height = int.Parse(line[1]);

            if (!logs.ContainsKey(woodType))
            {
                logs[woodType] = new List<decimal>();
            }

            logs[woodType].Add(height);

            input = Console.ReadLine();
        }

        var flatteredNumbers = logs.SelectMany(x => x.Value).ToList();
        decimal pricePerMeter = (decimal)flatteredNumbers.Average();
        pricePerMeter = Math.Round(pricePerMeter, 2);

        input = Console.ReadLine();

        int minHeight = int.Parse(Console.ReadLine());

        
            var usedLogs = logs
                .Where(x => x.Key == input)
                .SelectMany(x => x.Value)
                .Where(x => x >= minHeight)
                .ToList();

            decimal usedLogPrice = Math.Round(usedLogs.Sum() * pricePerMeter, 2);

            var unusedLogs = logs
                .Where(x => x.Key != input)
                .SelectMany(x => x.Value)
                .ToList();

            foreach (var value in logs[input])
            {
                if (value < minHeight)
                {
                    unusedLogs.Add(value);
                }
            }

        decimal unusedLogPrice = unusedLogs.Sum() * pricePerMeter;
            unusedLogPrice = Math.Round(unusedLogPrice * (decimal)0.25, 2);

            decimal total = usedLogPrice + unusedLogPrice;

            PrintResult(pricePerMeter, usedLogPrice, unusedLogPrice, total);
        
    }

    private static void PrintResult(decimal pricePerMeter, decimal usedLogPrice, decimal unusedLogPrice, decimal total)
    {
        Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
        Console.WriteLine($"Used logs price: ${usedLogPrice:f2}");
        Console.WriteLine($"Unused logs price: ${unusedLogPrice:f2}");
        Console.WriteLine($"CottageScraper subtotal: ${total:f2}");
    }
}
