using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.Hideout
{
    class Hideout
    {
        static void Main()
        {
            string map = Console.ReadLine();

            while (true)
            {
                var line = Console.ReadLine().Split();
                string searchedCharacter = line[0];
                string minimumCount = line[1];

                var match = Regex.Match(map, @"\" + searchedCharacter + "{" + minimumCount + ",}");

                if (match.Success)
                {
                    int index = map.IndexOf(match.Value);
                    int count = match.Value.Length;

                    Console.WriteLine($"Hideout found at index {index} and it is with size {count}!");
                    break;
                }
            }
        }
    }
}
