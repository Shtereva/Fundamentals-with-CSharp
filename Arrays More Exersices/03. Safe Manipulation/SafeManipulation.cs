using System;
using System.Collections.Generic;
using System.Linq;
class ManipulateArray
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        string line = Console.ReadLine();

        while (line != "END")
        {
            var command = line.Split();

            switch (command[0])
            {
                case "Reverse":
                    input = input.Reverse().ToArray();
                    break;
                case "Distinct":
                    input = input.Distinct().ToArray();
                    break;
                case "Replace":
                    ReplaceElementInArray(input, command);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

            line = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", input));
    }

    private static void ReplaceElementInArray(string[] input, string[] command)
    {
        try
        {
            input[int.Parse(command[1])] = command[2];
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
