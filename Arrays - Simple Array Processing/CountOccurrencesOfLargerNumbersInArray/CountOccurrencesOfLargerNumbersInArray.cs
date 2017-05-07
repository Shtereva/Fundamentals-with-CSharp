using System;
using System.Linq;

namespace CountOccurrencesOfLargerNumbersInArray
{
    class CountOccurrencesOfLargerNumbersInArray
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double number = double.Parse(Console.ReadLine());
            int count = 0;

            foreach (var item in array)
            {
                if (item > number)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
