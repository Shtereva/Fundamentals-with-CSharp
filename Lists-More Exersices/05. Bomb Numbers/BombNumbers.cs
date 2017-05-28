using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Bomb_Numbers
{
    class BombNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var specialNumber = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = specialNumber[0];
            int power = specialNumber[1];
            int sum = 0;

            FindingBombNumberIndex(numbers, bombNumber, power);
            sum = SumNumbers(numbers, sum);

            Console.WriteLine(sum);
        }

        private static int SumNumbers(List<int> numbers, int sum)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static void FindingBombNumberIndex(List<int> numbers, int bombNumber, int power)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                bool hasMatch = numbers.Contains(bombNumber);

                if (hasMatch == false)
                {
                    return;
                }
                if (numbers[i].Equals(bombNumber))
                {
                    BombingNumbers(numbers, power, i);
                    i = -1;
                }
            }
        }

        private static void BombingNumbers(List<int> numbers, int power, int i)
        {
            if (i - power >= 0 && i + power <= numbers.Count - 1)
            {
                numbers.RemoveRange(i - power, (power * 2) + 1);

            }

            else if (i - power >= 0 && i + power > numbers.Count - 1)
            {
                numbers.RemoveRange(i - power, numbers.Count - (i - power));
            }

            else if (i - power < 0 && i + power <= numbers.Count - 1)
            {
                numbers.RemoveRange(0, i + 1 + power);
            }

            else
            {
                numbers.RemoveRange(0, numbers.Count);
            }
        }
    }
}
