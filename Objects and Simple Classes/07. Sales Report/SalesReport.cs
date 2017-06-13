using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Sales_Report
{
    class SalesReport
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var lineAsString = Console.ReadLine();
                var sale = Sale.Parse(lineAsString);

                if (!salesByTown.ContainsKey(sale.Town))
                {
                    salesByTown[sale.Town] = 0;
                }

                salesByTown[sale.Town] += sale.Quantity * sale.Price;
            }

            salesByTown
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} -> {x.Value:f2}"));
        }

    }
}
