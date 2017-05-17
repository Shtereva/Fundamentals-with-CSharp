using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseArrayInplace
{
    class ReverseArrayInplace
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
