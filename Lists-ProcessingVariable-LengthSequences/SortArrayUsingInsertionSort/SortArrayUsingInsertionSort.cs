using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArrayUsingInsertionSort
{
    class SortArrayUsingInsertionSort
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = new List<int>(numbers.Length);
            bool isSmaller = false;

            do
            {
                isSmaller = false;
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < numbers[i -1])
                    {
                        int temp = numbers[i - 1];
                        numbers[i - 1] = numbers[i];
                        numbers[i] = temp;
                        isSmaller = true;
                    }
                }
            } while (isSmaller);

            for (int i = 0; i < numbers.Length; i++)
            {
                result.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
