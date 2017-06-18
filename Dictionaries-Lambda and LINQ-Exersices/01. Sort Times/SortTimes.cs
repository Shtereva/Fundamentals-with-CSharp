using System;
using System.Collections.Generic;
using System.Linq;

class SortTimes
{
    static void Main()
    {
        var input = Console.ReadLine()
            .Split()
            .OrderBy(x => x)
            .ToList();

        Console.WriteLine(string.Join(", ", input));
    }
}

