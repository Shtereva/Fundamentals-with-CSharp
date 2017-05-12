using System;
using System.Collections.Generic;
using System.Linq;

namespace TearListInHalf
{
    class TearListInHalf
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var rightList = new List<int>();
            var leftList = new List<int>();
            int half = numbers.Count / 2;
            SeparatingList(numbers, rightList, half, leftList);
            TearList(rightList, half, leftList);
            Console.WriteLine(string.Join(" ", leftList));
        }

        private static void TearList(List<int> rightList, int half, List<int> leftList)
        {
            int index = 0;
            for (int i = 0; i < leftList.Count; i += 3)
            {
                int infrontNumber = rightList[index] / 10;
                leftList.Insert(i, infrontNumber);
                int behindNumber = rightList[index] % 10;
                leftList.Insert(i + 2, behindNumber);
                index++;
            }
        }

        private static void SeparatingList(List<int> numbers, List<int> rightList, int half, List<int> leftList)
        {
            for (int i = half; i < numbers.Count; i++)
            {
                rightList.Add((numbers[i]));
            }

            for (int i = 0; i < half; i++)
            {
                leftList.Add(numbers[i]);
            }
        }
    }
}
