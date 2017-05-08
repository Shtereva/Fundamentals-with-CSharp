using System;
using System.Linq;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int pairLenght = array.Count() / 4;
            var upperRow = new int[pairLenght * 2];
            var lowerRow = new int[pairLenght * 2];
            var result = new int[pairLenght * 2];
            for (int i = 0; i < pairLenght; i++)
            {
                upperRow[i % pairLenght] = array[pairLenght - i - 1];
                upperRow[upperRow.Length - 1 - i] = array[array.Length - pairLenght + i];
            }

            for (int i = pairLenght; i < array.Length - pairLenght; i++)
            {
                int index = pairLenght;
                lowerRow[i - index] = array[i];
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
