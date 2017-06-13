using System;
using System.Collections.Generic;
using System.Linq;
class SearchForANumber
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        numbers = numbers
            .Take(array[0])
            .Skip(array[1])
            .ToList();

        Console.WriteLine(numbers.Contains(array[2]) ? "YES!" : "NO!");
    }
}
