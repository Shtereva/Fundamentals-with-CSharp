using System;
using System.Linq;
namespace PairsByDifference
{
    class PairsByDifference
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;
            counter = CheckDifference(array, difference, counter);
            Console.WriteLine(counter);
        }

        private static int CheckDifference(int[] array, int difference, int counter)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (Math.Abs(array[i] - array[j]) == difference)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }
    }
}
