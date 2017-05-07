using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isOneNumber = false;
            while (numbers.Count() > 1)
            {
                isOneNumber = true;
                int[] condensed = new int[numbers.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condensed;
            }

            Console.WriteLine(isOneNumber == true ? string.Join("", numbers) : $"{string.Join("", numbers)} is already condensed to number");
        }
    }
}
