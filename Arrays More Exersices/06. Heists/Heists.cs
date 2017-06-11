using System;
using System.Collections.Generic;
using System.Linq;
class Heists
{
    static void Main()
    {
        var prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int jewelsPrice = prices[0];
        int goldPrice = prices[1];

        string input = Console.ReadLine();
        long earnings = 0;
        long expenses = 0;

        while (input != "Jail Time")
        {
            var line = input.Split();
            var loot = line[0].ToCharArray();
            expenses += long.Parse(line[1]);
            earnings = CheckEarnings(jewelsPrice, goldPrice, earnings, loot);

            input = Console.ReadLine();
        }

        if (earnings >= expenses)
        {
            Console.WriteLine($"Heists will continue. Total earnings: {Math.Abs(earnings - expenses)}.");
        }

        else
        {
            Console.WriteLine($"Have to find another job. Lost: {Math.Abs(expenses - earnings)}.");
        }
    }

    private static long CheckEarnings(int jewelsPrice, int goldPrice, long earnings, char[] loot)
    {
        for (int i = 0; i < loot.Length; i++)
        {
            if (loot[i] == '%')
            {
                earnings += jewelsPrice;
            }

            if (loot[i] == '$')
            {
                earnings += goldPrice;
            }
        }

        return earnings;
    }
}
