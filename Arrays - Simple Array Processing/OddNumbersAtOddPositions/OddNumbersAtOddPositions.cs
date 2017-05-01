using System;
using System.Linq;

namespace OddNumbersAtOddPositions
{
    class OddNumbersAtOddPositions
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0 && Math.Abs(array[i]) % 2 != 0)
                {
                    Console.WriteLine("Index {0} -> {1}", i, array[i]);
                }
            }
        }
    }
}
