using System;
using System.Collections.Generic;
using System.Linq;


namespace SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }
            , StringSplitOptions.RemoveEmptyEntries).ToList();
            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();
            CheckLetters(text, lowerCase, mixedCase, upperCase);
            PrintResult(lowerCase, mixedCase, upperCase);
        }

        private static void PrintResult(List<string> lowerCase, List<string> mixedCase, List<string> upperCase)
        {
            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");

        }

        private static void CheckLetters(List<string> text, List<string> lowerCase, List<string> mixedCase, List<string> upperCase)
        {
            for (int i = 0; i < text.Count; i++)
            {
                int countLower = 0;
                int countUpper = 0;

                CountUpperAndLowerLetters(text, ref countLower, ref countUpper, i);
                AddLettersTLists(text, lowerCase, mixedCase, upperCase, countLower, countUpper, i);
            }
        }

        private static void AddLettersTLists(List<string> text, List<string> lowerCase, List<string> mixedCase, List<string> upperCase, int countLower, int countUpper, int i)
        {
            if (countLower == text[i].Length)
            {
                lowerCase.Add(text[i]);
            }

            else if (countUpper == text[i].Length)
            {
                upperCase.Add(text[i]);
            }

            else
            {
                mixedCase.Add(text[i]);
            }
        }

        private static void CountUpperAndLowerLetters(List<string> text, ref int countLower, ref int countUpper, int i)
        {
            foreach (var item in text[i])
            {
                if (item >= 97 && item <= 122)
                {
                    countLower++;
                }

                if (item >= 65 && item <= 90)
                {
                    countUpper++;
                }
            }
        }
    }
}
