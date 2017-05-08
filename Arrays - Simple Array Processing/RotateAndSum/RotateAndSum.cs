using System;
using System.Linq;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = new int[array.Length];
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int zeroElement = array[array.Length - 1];

                for (int j = 1; j < array.Length; j++)
                {
                    array[array.Length - j] = array[array.Length - 1 - j];
                }
                array[0] = zeroElement;
                result = array.Clone() as int[];
            }

            for (int r = 1; r < rotations; r++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = result[i] + array[(i + r) % array.Length];
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
