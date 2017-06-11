using System;
using System.Collections.Generic;
using System.Linq;
class ManipulateArray
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var command = Console.ReadLine();

            switch (command)
            {
                case "Reverse":
                    input = input.Reverse().ToArray();
                    break;
                case "Distinct":
                    input = input.Distinct().ToArray();
                    break;
            }

            if (command.Length > 8)
            {
                var line = command.Split();
                input[int.Parse(line[1])] = line[2];
            }
        }

        Console.WriteLine(string.Join(", ", input));
    }
}
