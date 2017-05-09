using System;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            var array = Console.ReadLine().Split();
            int start = array.Length - 1;
            int len = 1;
            int bestStart = 0;
            int bestLen = 0;

            CheckEquals(array, ref start, ref len, ref bestLen, ref bestStart);
            PrintLongestSequens(bestStart, bestLen, array);
            if (len == 1 && bestLen == 0)
            {
                Console.Write(array[0]);
            }
            Console.WriteLine();
        }

        private static void PrintLongestSequens(int bestStart, int bestLen, string[] array)
        {
            for (int i = bestStart; i > bestStart - bestLen; i--)
            {
                //if (i == array.Length - 2 && bestStart == 0 )
                //{
                //    bestLen++;
                //}
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }

        private static void CheckEquals(string[] array, ref int start, ref int len, ref int bestLen, ref int bestStart)
        {
            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i].Equals(array[i + 1]))
                {
                    len++;
                    if (len >= bestLen)
                    {
                        bestStart = start;
                        bestLen = len;
                    }
                }

                else
                {
                    start = i;
                    len = 1;
                }
            }
        }
    }
}
