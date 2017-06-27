using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.Letters_Change_Numbers
{
    class LettersChangeNumbers
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;

            foreach (var word in input)
            {
                string leftPart = new string(word.TakeWhile(x => char.IsLetter(x)).ToArray());

                string findDigits = new string(word.Where(x => char.IsDigit(x)).ToArray());
                ulong num = ulong.Parse(findDigits);

                string rightPart = new string(word.Reverse().TakeWhile(x => char.IsLetter(x)).ToArray());

                decimal tempSum = 0;

                tempSum = CalculateLeftPart(leftPart, num, tempSum);
                tempSum = CalculateRightPart(rightPart, tempSum);

                sum += tempSum;
            }

            Console.WriteLine($"{sum:f2}");
        }

        private static decimal CalculateRightPart(string rightPart, decimal tempSum)
        {
            if (char.IsUpper(Convert.ToChar(rightPart)))
            {
                tempSum -= (Convert.ToChar(rightPart) % 32);
            }

            if (char.IsLower(Convert.ToChar(rightPart)))
            {
                tempSum += (Convert.ToChar(rightPart) % 32);
            }

            return tempSum;
        }

        private static decimal CalculateLeftPart(string leftPart, ulong num, decimal tempSum)
        {
            if (char.IsUpper(Convert.ToChar(leftPart)))
            {
                tempSum = (decimal)num / (Convert.ToChar(leftPart) % 32);
            }

            if (char.IsLower(Convert.ToChar(leftPart)))
            {
                tempSum = (decimal)num * (Convert.ToChar(leftPart) % 32);
            }

            return tempSum;
        }
    }
}
