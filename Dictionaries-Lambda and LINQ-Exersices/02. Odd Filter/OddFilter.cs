using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class OddFilter
{
    static void Main()
    {
        var evenNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .ToList();

        double average = evenNumbers.Average();

        var result = evenNumbers
            .Select(x => x > average ? ++x : --x)
            .ToList();

        Console.WriteLine(string.Join(" ", result));
    }
}
