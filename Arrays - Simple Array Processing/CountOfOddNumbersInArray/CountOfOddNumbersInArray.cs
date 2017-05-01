using System;
using System.Linq;


namespace CountOfOddNumbersInArray
{
    class CountOfOddNumbersInArray
    {
        static void Main()
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int countOddElement = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) % 2 != 0)
                {
                    countOddElement++;
                }
            }
            Console.WriteLine(countOddElement);
        }
    }
}
