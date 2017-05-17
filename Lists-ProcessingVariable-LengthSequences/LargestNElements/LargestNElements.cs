using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNElements
{
    class LargestNElements
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int countElements = int.Parse(Console.ReadLine());
            SortElements(numbers);
            ReverseElements(numbers);

            for (int i = 0; i < countElements; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        private static void ReverseElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = temp;
            }
        }

        private static void SortElements(List<int> numbers)
        {
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
        }
    }
}
