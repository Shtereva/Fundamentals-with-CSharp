using System;
using System.Collections.Generic;
using System.Linq;
class SupermarketDatabase
{
    static void Main()
    {
        string input = Console.ReadLine();
        var products = new Dictionary<string, Dictionary<decimal, int>>();

        while (input != "stocked")
        {
            var line = input.Split();

            string product = line[0];
            decimal price = decimal.Parse(line[1]);
            int quantity = int.Parse(line[2]);

            if (products.ContainsKey(product))
            {
                var newQuantity = products[product].Select(x => x.Value + quantity).ToArray();
                products[product] = new Dictionary<decimal, int>();
                products[product][price] = newQuantity[0];
            }

            if (!products.ContainsKey(product))
            {
                products[product] = new Dictionary<decimal, int>();
                products[product][price] = quantity;
            }

            input = Console.ReadLine();
        }

        PrintTotal(products);
    }

    private static void PrintTotal(Dictionary<string, Dictionary<decimal, int>> products)
    {
        decimal totalSum = 0;

        foreach (var product in products)
        {
            var price = product.Value.Select(x => x.Key).Sum();
            var quantity = product.Value.Select(x => x.Value).Sum();
            Console.WriteLine($"{product.Key}: ${price:f2} * {quantity} = ${price * quantity:f2}");
            totalSum += price * quantity;
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${totalSum:f2}");
    }
}
