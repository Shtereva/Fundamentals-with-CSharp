using System;
using System.Linq;

namespace IncreasingSequenceOfElements
{
    class IncreasingSequenceOfElements
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            bool isSequence = true;

            for (int i = array.Length - 1; i > 0; i--)
            {
                if (i == 0) { break; }

                if (array[i] < array[i - 1])
                {
                    isSequence = false;
                }
            }

            Console.WriteLine(isSequence ? "Yes" : "No");
        }
    }
}
