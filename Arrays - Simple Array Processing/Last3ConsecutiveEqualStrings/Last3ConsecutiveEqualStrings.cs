using System;
using System.Linq;

namespace Last3ConsecutiveEqualStrings
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main()
        {
            var arrOfStrings = Console.ReadLine().Split(' ');
            string firstWord = null;
            string secondWord = null;

            for (int i = arrOfStrings.Length - 1; i >= 0; i--)
            {
                string currentWord = arrOfStrings[i];
                if (currentWord == firstWord && firstWord != secondWord)
                {
                    secondWord = firstWord;
                    continue;
                }
                if (secondWord == currentWord && firstWord == secondWord)
                {
                    Console.WriteLine("{0} {1} {2}", firstWord, secondWord, currentWord);
                    break;
                }
                firstWord = currentWord;
            }
        }
    }
}
