using System;
using System.Collections.Generic;
using System.Linq;

namespace DistinctList
{
    class DistinctList
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            RemoveRepeatedNumbers(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void RemoveRepeatedNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i].Equals(numbers[j]))
                    {
                        numbers.RemoveAt(j);
                        i--;
                        break;
                    }
                }
            }
        }
    }
}
