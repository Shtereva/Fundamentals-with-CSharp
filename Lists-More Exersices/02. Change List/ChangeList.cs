using System;
using System.Collections.Generic;
using System.Linq;
class ChangeList
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string input = Console.ReadLine();

        while (input != "Odd" && input != "Even")
        {
            var line = input.Split();
            string command = line[0];
            int element = int.Parse(line[1]);

            switch (command)
            {
                case "Delete":
                    numbers.RemoveAll(x => x.Equals(element));
                    break;
                case "Insert":
                    int possition = int.Parse(line[2]);
                    numbers.Insert(possition, element);
                    break;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(input == "Odd" ? string.Join(" ", numbers.Where(x => x % 2 != 0)) : string.Join(" ", numbers.Where(x => x % 2 == 0)));

    }
}
