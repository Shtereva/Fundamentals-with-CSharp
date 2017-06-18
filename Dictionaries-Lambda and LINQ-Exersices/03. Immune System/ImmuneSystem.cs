using System;
using System.Collections.Generic;
using System.Linq;
class ImmuneSystem
{
    static void Main()
    {
        int inittialHealth = int.Parse(Console.ReadLine());
        int health = inittialHealth;
        bool secondFlue = false;

        string virusName = Console.ReadLine();
        var encounteredViruses = new List<string>();

        while (virusName != "end")
        {
            bool isDefeated = false;

            var virusStrenght = virusName.ToCharArray().Select(x => Convert.ToInt32(x)).Sum() / 3;
            int defeatTime = 0;

            defeatTime = CalculateDefeatTime(virusName, encounteredViruses, virusStrenght, ref secondFlue);

            PrintCurrentHealthStatus(health, virusName, virusStrenght, defeatTime, ref isDefeated);
            health = (health - defeatTime);

            if (isDefeated)
            {
                return;
            }

            double regeneratedHealth = health * 0.20;
            health += (int)regeneratedHealth;

            if (health > inittialHealth)
            {
                health = inittialHealth;
            }

            encounteredViruses.Add(virusName);

            if (secondFlue)
            {
                encounteredViruses.RemoveAll(x => x == virusName);
                secondFlue = false;
            }
            virusName = Console.ReadLine();
        }

        Console.WriteLine($"Final Health: {health}");
    }

    private static void PrintCurrentHealthStatus(int health, string virusName, int virusStrenght, int defeatTime, ref bool isDefeated)
    {
        Console.WriteLine($"Virus {virusName}: {virusStrenght} => {defeatTime} seconds");
        if (defeatTime > health)
        {
            Console.WriteLine("Immune System Defeated.");
            isDefeated = true;
            return;
        }
        Console.WriteLine($"{virusName} defeated in {defeatTime / 60}m {defeatTime % 60}s.");
        Console.WriteLine($"Remaining health: {health - defeatTime}");
    }

    private static int CalculateDefeatTime(string virusName, List<string> encounteredViruses, int virusStrenght,ref bool secondFlue)
    {
        int defeatTime;
        if (encounteredViruses.Contains(virusName))
        {
            defeatTime = (virusStrenght * virusName.Length) / 3;
            secondFlue = true;
        }

        else
        {
            defeatTime = virusStrenght * virusName.Length;
        }

        return defeatTime;
    }
}
