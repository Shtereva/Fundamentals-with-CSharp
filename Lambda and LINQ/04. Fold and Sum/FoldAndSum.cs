using System;
using System.Collections.Generic;
using System.Linq;
class FoldAndSum
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int k = numbers.Count / 4;

        var leftPart = numbers.Take(k).Reverse().ToList();
        numbers.Reverse();
        var rightPart = numbers.Take(k).ToList();

        var upperRow = leftPart.Concat(rightPart).ToList();
        var belowRow = numbers.Skip(k).Take(2 * k).Reverse().ToList();

        var sum = upperRow.Select((x, index) => x + belowRow[index]).ToList();

        Console.WriteLine(string.Join(" ", sum));
    }
}
