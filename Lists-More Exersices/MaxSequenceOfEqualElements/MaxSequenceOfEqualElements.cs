using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();
            int start = 0;
            int lenght = 1;

            int bestStart = 0;
            int bestLenght = 1;
            ProcesList(numbers, ref start, ref lenght, ref bestStart, ref bestLenght);

            for (int i = bestStart; i <= numbers.Count - bestLenght; i++)
            {
                Console.Write(numbers[i] + " ");
            }

        }

        private static void ProcesList(List<int> numbers, ref int start, ref int lenght, ref int bestStart, ref int bestLenght)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i].Equals(numbers[i + 1]))
                {
                    lenght++;
                    start = i;
                }

                else
                {
                    if (bestLenght < lenght)
                    {
                        bestLenght = lenght;
                        bestStart = start;
                    }
                    lenght = 1;
                    start = 0;
                }
            }
        }
    }
}
