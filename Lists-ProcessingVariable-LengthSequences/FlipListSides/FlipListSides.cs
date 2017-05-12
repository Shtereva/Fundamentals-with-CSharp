using System;
using System.Collections.Generic;
using System.Linq;

namespace FlipListSides
{
    class FlipListSides
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            ReverseNumbers(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ReverseNumbers(List<int> numbers)
        {
            for (int i = 1; i <= (numbers.Count - 2) / 2; i++)
            {
                int num = numbers[numbers.Count - i - 1];
                numbers[numbers.Count - i - 1] = numbers[i];
                numbers[i] = num;
            }
        }
    }
}
