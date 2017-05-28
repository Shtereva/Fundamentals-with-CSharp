using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Letter_Repetition
{
    class LetterRepetition
    {
        static void Main()
        {
            var letters = Console.ReadLine().ToList();
            var countLetters = new Dictionary<char, int>();
            CountingLetters(letters, countLetters);

            letters.Clear();

            foreach (var kvp in countLetters)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }

        private static void CountingLetters(List<char> letters, Dictionary<char, int> countLetters)
        {
            foreach (var letter in letters)
            {
                if (!countLetters.ContainsKey(letter))
                {
                    countLetters[letter] = 0;
                }

                countLetters[letter]++;
            }
        }
    }
}
