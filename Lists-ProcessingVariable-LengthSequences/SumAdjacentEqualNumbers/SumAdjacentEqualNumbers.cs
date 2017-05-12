using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            CheckNumbers(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void CheckNumbers(List<decimal> numbers)
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    decimal sum = numbers[i - 1] + numbers[i];
                    numbers.RemoveRange(i - 1, 2);
                    numbers.Insert(i - 1, sum);
                    i = 0;
                }
            }
        }
    }
}
