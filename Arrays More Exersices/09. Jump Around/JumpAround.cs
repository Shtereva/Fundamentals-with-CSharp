using System;
using System.Collections.Generic;
using System.Linq;
class JumpAround
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int maxIndex = numbers.Length - 1;
        int sum = numbers[0];

        for (int i = 0; i <= maxIndex; i++)
        {
            if (numbers[i] + i <= maxIndex)
            {
                i = numbers[i] + i;
                sum += numbers[i];
                i--;
            }

            else
            {
                if (i - numbers[i] >= 0)
                {
                    i = i - numbers[i];
                    sum += numbers[i];
                    i--;
                }

                else
                {
                    break;
                }
            }
        }

        Console.WriteLine(sum);
    }
}
