using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var text = Console.ReadLine()
            .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(w => w.Length < 5)
            .OrderBy(w => w)
            .Select(w => w.ToLower())
            .Distinct()
            .ToList();

        Console.WriteLine(string.Join(", ", text));
    }
}
