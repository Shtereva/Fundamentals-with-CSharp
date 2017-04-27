using System;
using System.Numerics;

namespace EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string digitToLetter = GetLetter(Math.Abs(number));
            Console.WriteLine(digitToLetter);
        }

         static string GetLetter(long number)
        {
            long digit = number % 10;
            string digitToLetter = string.Empty;
            switch (digit.ToString())
            {
                case "0": digitToLetter = "zero"; break;
                case "1": digitToLetter = "one"; break;
                case "2": digitToLetter = "two"; break;
                case "3": digitToLetter = "three"; break;
                case "4": digitToLetter = "four"; break;
                case "5": digitToLetter = "five"; break;
                case "6": digitToLetter = "six"; break;
                case "7": digitToLetter = "seven"; break;
                case "8": digitToLetter = "eight"; break;
                case "9": digitToLetter = "nine"; break;
            }
            return digitToLetter;
        }
    }
}
