using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01.Softuni_Coffee_Orders
{
    class SoftuniCoffeeOrders
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalSum = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int days = DateTime.DaysInMonth(date.Year, date.Month);
                long capsulesCount = long.Parse(Console.ReadLine());
                
                decimal coffePrice = (days * capsulesCount) * pricePerCapsule;
                totalSum += coffePrice;

                Console.WriteLine($"The price for the coffee is: ${coffePrice:f2}");
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }

    internal class BigIntegr
    {
    }
}
