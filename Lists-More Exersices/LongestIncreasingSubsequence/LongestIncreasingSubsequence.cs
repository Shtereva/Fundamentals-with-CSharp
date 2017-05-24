using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();
            int startIndex = 0;
            FindTheStartOfSubSequence(numbers, result, ref startIndex);
            ProccesingList(numbers, result, startIndex);

            Console.WriteLine(string.Join(" ", result));
        }

        private static void ProccesingList(List<int> numbers, List<int> result, int startIndex)
        {
            for (int i = startIndex; i < numbers.Count; i++)
            {
                bool equalNum = result.Contains(numbers[i]);

                if (equalNum)
                {
                    continue;
                }

                else
                {
                    if (numbers[i] > result[result.Count - 1])
                    {
                        result.Add(numbers[i]);
                    }

                    else
                    {
                        CompareElements(numbers, result, i);
                    }
                }
            }
        }

        private static void FindTheStartOfSubSequence(List<int> numbers, List<int> result, ref int startIndex)
        {
            if (numbers.Count == 1)
            {
                result.Add(numbers[0]);
                return;
            }

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < numbers[0] && i != numbers.Count- 1 && numbers[i] < numbers[i + 1])
                {
                    result.Add(numbers[i]);
                    startIndex = i + 1;
                    return;
                }
            }

            result.Add(numbers[0]);
            startIndex = 1;
        }

        private static void CompareElements(List<int> numbers, List<int> result, int i)
        {
            if (i != numbers.Count - 1 && numbers[i] < numbers[i + 1])
            {
                for (int j = result.Count - 1; j > 0; j--)
                {
                    if (numbers[i] < result[j] && numbers[i] > result[j - 1])
                    {
                        result.RemoveRange(j, result.Count - j);
                        result.Add(numbers[i]);
                        break;
                    }
                }
            }

        }
    }
}
