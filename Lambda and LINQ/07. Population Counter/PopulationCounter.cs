using System;
using System.Collections.Generic;
using System.Linq;
class PopulationCounter
{
    static void Main()
    {
        string input = Console.ReadLine();
        var statistic = new Dictionary<string, Dictionary<string, long>>();

        while (input != "report")
        {
            var line = input.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string country = line[1];
            string city = line[0];
            int population = int.Parse(line[2]);

            if (!statistic.ContainsKey(country))
            {
                statistic[country] = new Dictionary<string, long>();
            }
            statistic[country][city] = population;

            input = Console.ReadLine();
        }

        statistic = statistic
            .OrderByDescending(country => country.Value.Sum(city => city.Value))
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var country in statistic)
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(x => x.Value)})");

            country.Value
                .OrderByDescending(x => x.Value)
                .ToList()
                .ForEach(x => Console.WriteLine($"=>{x.Key}: {x.Value}"));
            
        }            
    }
}
