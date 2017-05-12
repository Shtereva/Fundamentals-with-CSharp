using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            RemoveOccuredElements(firstList, secondList);
            PrintResult(firstList, secondList);

        }

        private static void PrintResult(List<int> firstList, List<int> secondList)
        {
            if (firstList.Sum() == secondList.Sum())
            {
                int sum = firstList.Sum();
                Console.WriteLine($"Yes. Sum: {sum}");
            }

            else
            {
                int sum = Math.Abs(firstList.Sum() - secondList.Sum());
                Console.WriteLine($"No. Diff: {sum}");
            }
        }

        private static void RemoveOccuredElements(List<int> firstList, List<int> secondList)
        {
            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i]))
                {
                    secondList.RemoveAll(x => x == firstList[i]);
                }
            }
        }
    }
}
