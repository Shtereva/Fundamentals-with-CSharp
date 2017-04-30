using System;
using System.Linq;


namespace SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main()
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int smallestElement = int.MaxValue;

            foreach (var digit in array)
            {
                if (digit < smallestElement)
                {
                    smallestElement = digit;
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
