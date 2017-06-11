using System;
using System.Collections.Generic;
using System.Linq;
class GrabAndGo
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long num = int.Parse(Console.ReadLine());

        if (!numbers.Contains(num))
        {
            Console.WriteLine("No occurrences were found!");
        }

        else
        {
            var index = 0;
            long sum = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] == num)
                {
                    index = i;
                    break;
                }
            }

            for (int i = 0; i < index; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
