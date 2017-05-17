using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main()
        {
            var strings = Console.ReadLine().Split();
            int averageSum = 0;
            int countChars = 0;
            GetLettersSum(strings, ref averageSum, ref countChars);
            averageSum = averageSum / countChars;
            int delimeter = 0;
            delimeter = CheckLetterCase(averageSum);

            Console.WriteLine(string.Join($"{(char)delimeter}", strings));
        }

        private static int CheckLetterCase(int averageSum)
        {
            int delimeter;
            if (averageSum >= 97 && averageSum <= 122)
            {
                delimeter = averageSum - 32;
            }
            else
            {
                delimeter = averageSum;
            }

            return delimeter;
        }

        private static void GetLettersSum(string[] strings, ref int averageSum, ref int countChars)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                foreach (char letter in strings[i])
                {
                    averageSum += letter;
                    countChars++;
                }
            }
        }
    }
}
