using System;
using System.Linq;

namespace RoundingNumbersAwayfromZero
{
    class RoundingNumbersAwayfromZero
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                decimal rounded = Math.Round(array[i], 5, MidpointRounding.AwayFromZero);
                Console.WriteLine(array[i] + " => " + Math.Round(rounded, MidpointRounding.AwayFromZero));
            }
        }
    }
}
