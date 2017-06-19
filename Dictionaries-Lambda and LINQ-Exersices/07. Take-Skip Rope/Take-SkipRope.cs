using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Take_Skip_Rope
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().ToCharArray();

            var digits = line
                .Where(char.IsDigit)
                .Select(x => int.Parse(x.ToString()))
                .ToArray();

            var characters = line
                .Where(x => !char.IsDigit(x))
                .ToArray();

            var takeList = digits
                .Where((x, index) => index % 2 == 0)
                .ToArray();

            var skipList = digits
                .Where((x, index) => index % 2 != 0)
                .ToArray();

            string result = string.Empty;
            int total = 0;

            for (int i = 0; i < takeList.Length; i++)
            {
                var temp = characters.Skip(total).Take(takeList[i]).ToArray();
                total += skipList[i] + takeList[i];
                result += string.Join("", temp);
            }

            Console.WriteLine(result);
        }
    }
}
