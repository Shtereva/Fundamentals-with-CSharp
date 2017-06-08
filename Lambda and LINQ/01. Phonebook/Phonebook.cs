using System;
using System.Collections.Generic;
using System.Linq;
class Phonebook
{
    static void Main()
    {
        string input = Console.ReadLine();
        var phoneBook = new SortedDictionary<string, string>();

        while (input != "END")
        {
            var line = input.Split();

            if (line[0] == "A")
            {
                phoneBook[line[1]] = line[2];
            }

            else if(line[0] == "S")
            {
                Console.WriteLine(phoneBook.ContainsKey(line[1]) ? $"{line[1]} -> {phoneBook[line[1]]}" : $"Contact {line[1]} does not exist.");
            }

            else
            {
                foreach (var item in phoneBook)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }

            input = Console.ReadLine();
        }
    }
}
