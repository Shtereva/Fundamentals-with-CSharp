using System;
using System.Collections.Generic;
using System.Linq;
class Largest3Numbers
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .OrderByDescending(x => x)
            .Take(3)
            .ToList();

        Console.WriteLine(string.Join(" ", numbers));
    }
}
