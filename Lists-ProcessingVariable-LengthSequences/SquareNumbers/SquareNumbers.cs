using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var squareNumbers = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    squareNumbers.Add(numbers[i]);
                }
            }
            squareNumbers.Sort((a, b) => b.CompareTo(a));

            //squareNumbers.Reverse();
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}
