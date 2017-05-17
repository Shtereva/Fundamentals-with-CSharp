using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numberToContain = int.Parse(Console.ReadLine());
            bool hasMatch = false;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numberToContain)
                {
                    hasMatch = true;
                    break;
                }
            }

            Console.WriteLine(hasMatch ? "yes" : "no");
        }
    }
}
