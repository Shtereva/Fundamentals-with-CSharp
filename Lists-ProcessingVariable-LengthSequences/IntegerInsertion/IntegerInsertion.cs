using System;
using System.Collections.Generic;
using System.Linq;

namespace IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            input = InsertNumbers(numbers, input);
            Console.WriteLine(string.Join(" ", numbers));

        }

        private static string InsertNumbers(List<int> numbers, string input)
        {
            while (input != "end")
            {
                int firstDigit = int.Parse(input[0].ToString());
                numbers.Insert(firstDigit, int.Parse(input));
                input = Console.ReadLine();
            }

            return input;
        }
    }
}
