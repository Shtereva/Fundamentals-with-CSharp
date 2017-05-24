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
            int lenght = 1;

            int bestStart = 0;
            int bestLenght = 1;
            ProcesList(numbers, ref lenght, ref bestStart, ref bestLenght);

            for (int i = bestStart; i < bestStart + bestLenght; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

        }

        private static void ProcesList(List<int> numbers, ref int lenght, ref int bestStart, ref int bestLenght)
        {
            int currentIndex = 0;
;            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i].Equals(numbers[i + 1]))
                {
                    lenght++;
                }

                else
                {
                    if (bestLenght < lenght )
                    {
                        bestLenght = lenght;
                        bestStart = i - bestLenght + 1;
                    }
                    lenght = 1;
                }
                currentIndex = i + 1;
            }

            if (bestLenght < lenght )
            {
                bestLenght = lenght;
                bestStart = currentIndex - bestLenght + 1;
            }
        }
    }
}
