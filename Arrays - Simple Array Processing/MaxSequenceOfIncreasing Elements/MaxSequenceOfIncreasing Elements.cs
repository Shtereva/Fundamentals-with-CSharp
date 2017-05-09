using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split();
            int start = array.Length - 1;
            int len = 1;
            int bestStart = 0;
            int bestLen = 0;

            CheckIncreasingElements(array, ref start, ref len, ref bestLen, ref bestStart);

            var finalArray = new string[bestLen];

            PrintIncreasingElements(bestStart, bestLen, array, finalArray);
            if (len == 1 && bestLen == 0)
            {
                Console.WriteLine(array.Min());
            }
            else
            {
                Console.WriteLine(string.Join(" ", finalArray.Reverse()));
            }
        }

        private static void PrintIncreasingElements(int bestStart, int bestLen, string[] array, string[] finalArray)
        {
            int index = 0;
            for (int i = bestStart; i > bestStart - bestLen; i--)
            {
                finalArray[index] = (array[i]);
                index++;
            }
        }

        private static void CheckIncreasingElements(string[] array, ref int start, ref int len, ref int bestLen, ref int bestStart)
        {
            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (int.Parse(array[i]) < int.Parse(array[i + 1]))
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
