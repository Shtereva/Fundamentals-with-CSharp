using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Capitalize_Words
{
    class CapitalizeWords
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                var line = input.ToCharArray()
                    .Where(x => x != '\'')
                    .Where(x => !char.IsLetter(x))
                    .Where(x => !char.IsDigit(x))
                    .Where(x => !char.IsNumber(x))
                    .Distinct()
                    .ToArray();

                for (int i = 0; i < line.Length; i++)
                {
                    input = input.Replace(line[i].ToString(), " ");
                }
                var capitalLetters = input
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < capitalLetters.Length; i++)
                {
                    string firstLetter = capitalLetters[i].First().ToString().ToUpper();
                    var word = capitalLetters[i].Skip(1).ToArray();
                    capitalLetters[i] = firstLetter + string.Join("", word);
                }

                Console.WriteLine(string.Join(", ", capitalLetters));
                input = Console.ReadLine().ToLower();
            }
        }
    }
}
