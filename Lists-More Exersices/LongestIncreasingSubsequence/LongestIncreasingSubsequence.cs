using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var longestIncreasingSubsequence = FindLongestIncreasingSubSequence(numbers);
            Console.WriteLine(string.Join(" ", longestIncreasingSubsequence));
        }

        private static int[] FindLongestIncreasingSubSequence(int[] arr)
        {
            var lenghts = new int[arr.Length];
            var previous = new int[arr.Length];

            int bestLenght = 0;
            int lastIndex = -1;

            for (int anchor = 0; anchor < arr.Length; anchor++)
            {
                lenghts[anchor] = 1;
                previous[anchor] = -1;

                var anchorNum = arr[anchor];

                for (int i = 0; i < anchor; i++)
                {
                    var currentNum = arr[i];

                    if (currentNum < anchorNum && lenghts[i] + 1 > lenghts[anchor])
                    {
                        lenghts[anchor] = lenghts[i] + 1;
                        previous[anchor] = i;
                    }
                }

                if (lenghts[anchor] > bestLenght)
                {
                    bestLenght = lenghts[anchor];
                    lastIndex = anchor;
                }
            }

            var longestIncreasingSubSequence = new List<int>();

            while (lastIndex != - 1)
            {
                longestIncreasingSubSequence.Add(arr[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            longestIncreasingSubSequence.Reverse();
            return longestIncreasingSubSequence.ToArray();
        }
    }
}
