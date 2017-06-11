using System;
using System.Collections.Generic;
using System.Linq;
class PizzaIngredients
{
    static void Main()
    {
        var ingredients = Console.ReadLine().Split();
        int lenght = int.Parse(Console.ReadLine());
        int count = 0;
        var pizza = new List<string>();

        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i].Length == lenght)
            {
                Console.WriteLine($"Adding {ingredients[i]}.");
                pizza.Add(ingredients[i]);
                count++;
            }

            if (count >= 10)
            {
                break;
            }
        }

        Console.WriteLine($"Made pizza with total of {pizza.Count} ingredients.");
        Console.WriteLine($"The ingredients are: {string.Join(", ", pizza)}.");
    }
}
