using System;
using System.Linq;

namespace SumArrays
{
    class SumArrays
    {
        static void Main()
        {
            var arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = new int[Math.Max(arrayOne.Length, arrayTwo.Length)];

            for (int i = 0; i < Math.Max(arrayOne.Length, arrayTwo.Length); i++)
            {
                result[i] = arrayOne[i % arrayOne.Length] + arrayTwo[i % arrayTwo.Length];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
