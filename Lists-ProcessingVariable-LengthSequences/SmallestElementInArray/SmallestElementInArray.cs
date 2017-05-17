using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int smallestElement = int.MaxValue;

            foreach (var number in numbers)
            {
                if (number < smallestElement)
                {
                    smallestElement = number;
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
