using System;
using System.Collections.Generic;
using System.Linq;

namespace DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            var result = new List<char>();

            AddCharsToList(numbers, result);
            Console.WriteLine(string.Join("", result));
        }

        private static void AddCharsToList(decimal[] numbers, List<char> result)
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                int leftPart = (int)numbers[i];
                var right = numbers[i].ToString().Split('.');
                int rightPart = int.Parse(right[1]);

                if (leftPart != 0) { result.Insert(i, (char)leftPart); }
                ReverseList(result, i);
                if (rightPart != 0) { result.Insert(i, (char)rightPart); }
                ReverseList(result, i);
            }
        }

        private static void ReverseList(List<char> result, int i)
        {
            for (int j = i; j < result.Count - i; j++)
            {
                char temp = result[j];
                result[j] = result[result.Count - 1 - i];
                result[result.Count - 1 - i] = temp;
            }
        }
    }
}
