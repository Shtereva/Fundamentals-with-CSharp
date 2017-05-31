using System;
using System.Collections.Generic;
using System.Linq;

class RecordUniqueNames
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var listOfNames = new SortedSet<string>(); 

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            listOfNames.Add(line);
        }

        Console.WriteLine(string.Join(Environment.NewLine, listOfNames));
    }
}
