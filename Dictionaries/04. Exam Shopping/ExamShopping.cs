using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Exam_Shopping
{
    class ExamShopping
    {
        static void Main()
        {
            var product = Console.ReadLine().Split();
            var stock = new Dictionary<string, int>();

            while (product[0] != "exam")
            {
                if (product[0] == "stock")
                {
                    AddingProducts(product, stock);
                }

                if (product[0] == "buy")
                {
                    BuyingProducts(product, stock);
                }

                product = Console.ReadLine().Split();
            }

            PrintResult(stock);
        }

        private static void PrintResult(Dictionary<string, int> stock)
        {
            foreach (var item in stock)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }

        private static void BuyingProducts(string[] product, Dictionary<string, int> stock)
        {
            if (stock.ContainsKey(product[1]))
            {
                CheckingQuantity(product, stock);
            }

            else
            {
                Console.WriteLine($"{product[1]} doesn't exist");
            }
        }

        private static void CheckingQuantity(string[] product, Dictionary<string, int> stock)
        {
            if (stock[product[1]] > 0)
            {
                stock[product[1]] -= int.Parse(product[2]);

            }

            else
            {
                Console.WriteLine($"{product[1]} out of stock");
            }
        }

        private static void AddingProducts(string[] product, Dictionary<string, int> stock)
        {
            if (stock.ContainsKey(product[1]))
            {
                stock[product[1]] += int.Parse(product[2]);
            }

            else
            {
                stock.Add(product[1], int.Parse(product[2]));
            }
        }
    }
}
