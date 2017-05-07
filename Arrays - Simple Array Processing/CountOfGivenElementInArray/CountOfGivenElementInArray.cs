using System;
using System.Linq;

namespace CountOfGivenElementInArray
{
    class CountOfGivenElementInArray
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (var item in array)
            {
                if (item == element)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
