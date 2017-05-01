using System;
using System.Linq;

namespace ArrayElementsEqualToTheirIndex
{
    class ArrayElementsEqualToTheirIndex
    {
        static void Main()
        {
            var listOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < listOfIntegers.Length; i++)
            {
                if (i == listOfIntegers[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
