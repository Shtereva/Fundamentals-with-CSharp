using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Sum_Reversed_Numbers
{
    class SumReversedNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            sum = SumReversedElements(numbers, sum);
            Console.WriteLine(sum);
        }

        private static int SumReversedElements(List<int> numbers, int sum)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                string list = numbers[i].ToString();
                string reversed = string.Empty;

                for (int j = list.Length - 1; j >= 0; j--)
                {
                    reversed += list[j];
                }

                sum += int.Parse(reversed);
            }

            return sum;
        }
    }
}
