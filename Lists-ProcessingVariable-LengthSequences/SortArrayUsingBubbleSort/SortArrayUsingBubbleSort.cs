using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArrayUsingBubbleSort
{
    class SortArrayUsingBubbleSort
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool isBigger = true;

            do
            {
                isBigger = false;
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        isBigger = true;
                    }
                }
            } while (isBigger);


                Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
