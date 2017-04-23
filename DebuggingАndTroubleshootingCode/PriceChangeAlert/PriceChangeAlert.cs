using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double prices = double.Parse(Console.ReadLine());
            double diff = CalculateDiffPercentage(firstPrice, prices);
            bool isSignificantDifference = CheckThreshold(diff, threshold);
            string output = GetPriceChangeAlert(prices, firstPrice, diff, isSignificantDifference);
            Console.WriteLine(output);

            firstPrice = prices;
        }
    }

         static string GetPriceChangeAlert(double prices, double firstPrice, double diff, bool isSignificantDifference)
             {
                string output = string.Empty;
                if (diff == 0)
                {
                    output = string.Format("NO CHANGE: {0}", prices);
                }
                else if (!isSignificantDifference)
                {
                    output = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, prices, diff * 100);
                }
                else if (isSignificantDifference && (diff > 0))
                {
                    output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, prices, diff * 100);
                }
                else if (isSignificantDifference && (diff < 0))
                    output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, prices, diff * 100);
                return output;
             }

         static bool CheckThreshold(double diff, double threshold)
            {
                if (Math.Abs(diff) >= threshold)
                {
                    return true;
                }
                return false;
            }

     static double CalculateDiffPercentage(double firstPrice, double prices)
            {
                double sum = (prices - firstPrice) / firstPrice;
                return sum;
            }
}
