using System;
namespace _07.Sales_Report
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public static Sale Parse(string lineAsString)
        {
            var line = lineAsString.Split();
            return new Sale
            {
                Town = line[0],
                Product = line[1],
                Price = decimal.Parse(line[2]),
                Quantity = decimal.Parse(line[3])
            };
        }
    }
}
