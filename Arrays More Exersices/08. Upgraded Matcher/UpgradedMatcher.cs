using System;
using System.Collections.Generic;
using System.Linq;
class InventoryMatcher
{
    static void Main()
    {
        var products = Console.ReadLine().Split();
        var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
        var prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

        string command = Console.ReadLine();

        while (command != "done")
        {
            var line = command.Split();
            string name = line[0];
            long ordered = long.Parse(line[1]);

            int index = Array.IndexOf(products, name);
            if (index >= quantities.Length)
            {
                Console.WriteLine($"We do not have enough {name}");
            }

            else
            {
                CalculateSells(products, quantities, prices, name, ordered, index);
            }

            command = Console.ReadLine();
        }
    }

    private static void CalculateSells(string[] products, long[] quantities, decimal[] prices, string name, long ordered, int index)
    {
        if (ordered <= quantities[index])
        {
            decimal sum = prices[index] * (decimal)ordered;
            Console.WriteLine($"{products[index]} x {ordered} costs {sum:f2}");
            quantities[index] -= ordered;
        }

        else
        {
            Console.WriteLine($"We do not have enough {name}");
        }
    }
}
