using System;
using System.Linq;

namespace EqualSums
{
    class EqualSums
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool hasMatch = false;
            int output = 0;
            CheckEqualSums(array, ref hasMatch, ref output);

            Console.WriteLine(hasMatch ? $"{output}" : "no");
        }

        private static void CheckEqualSums(int[] array, ref bool hasMatch, ref int output)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int right = 0;
                int left = 0;

                for (int rightSum = i - 1; rightSum >= 0; rightSum--)
                {
                    right += array[rightSum];
                }
                for (int leftSum = i + 1; leftSum < array.Length; leftSum++)
                {
                    left += array[leftSum];
                }

                if (right == left)
                {
                    hasMatch = true;
                    output = i;
                    break;
                }
            }
        }
    }
}
