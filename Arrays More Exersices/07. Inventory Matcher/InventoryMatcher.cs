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
            int index = Array.IndexOf(products, command);
            Console.WriteLine($"{products[index]} costs: {prices[index]}; Available quantity: {quantities[index]}");

            command = Console.ReadLine();
        }
    }
}
