using System;
using System.Collections.Generic;
using System.Linq;
class DragonArmy
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        var dragons = new Dictionary<string, SortedDictionary<string, List<decimal>>>();
        // вид дракон <-key value -> име на дракон <-k v-> damage/health/armor

        for (int i = 0; i < num; i++)
        {
            var line = Console.ReadLine().Split();
            CheckForNullValues(line);

            string dragonType = line[0];
            string dragonName = line[1];
            decimal damage = decimal.Parse(line[2]);
            decimal health = decimal.Parse(line[3]);
            decimal armor = decimal.Parse(line[4]);

            if (!dragons.ContainsKey(dragonType))
            {
                dragons[dragonType] = new SortedDictionary<string, List<decimal>>();
            }
            dragons[dragonType][dragonName] = new List<decimal>() { damage, health, armor };
        }

        foreach (var type in dragons)
        {
            var dragonType = type.Key;
            var dragonNames = type.Value;

            var avgDamage = dragonNames.Average(x => x.Value[0]);
            var avgHealth = dragonNames.Average(x => x.Value[1]);
            var avgArmor = dragonNames.Average(x => x.Value[2]);

            Console.WriteLine($"{dragonType}::({avgDamage:f2}/{avgHealth:f2}/{avgArmor:f2})");

            foreach (var dragon in dragonNames)
            {
                Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
            }
        }
    }

    private static void CheckForNullValues(string[] line)
    {
        if (line[2] == "null")
        {
            line[2] = 45.ToString();
        }

        if (line[3] == "null")
        {
            line[3] = 250.ToString();
        }

        if (line[4] == "null")
        {
            line[4] = 10.ToString();
        }
    }
}
