using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                    i--;
                }
            }
            numbers.Reverse();
            Console.WriteLine(numbers.Count > 0 ? string.Join(" ", numbers) : "empty");
        }
    }
}
