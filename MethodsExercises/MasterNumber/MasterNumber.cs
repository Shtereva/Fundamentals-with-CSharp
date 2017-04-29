using System;
using System.Collections.Generic;


namespace MasterNumber
{
    class MasterNumber
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            for (long i = 1; i <= number; i++)
            {
                bool isPalindrome = IsPalindrome(i);
                bool sumDigits = SumOfDigits(i);
                bool isEven = ContainsEvenDigit(i);

                PrintMasterNumbers(isPalindrome, sumDigits, isEven, i);

            }
        }

        static void PrintMasterNumbers(bool isPalindrome, bool sumDigits, bool isEven, long number)
        {
            if (isPalindrome && sumDigits && isEven)
            {
                Console.WriteLine(number);
            }
        }

        static bool ContainsEvenDigit(long number)
        {
            while (number > 0)
            {
                long digit = number % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        static bool SumOfDigits(long number)
        {
            long sumNumbers = 0;
            while (number > 0)
            {
                sumNumbers += number % 10;
                number /= 10;
            }
            if (sumNumbers % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool IsPalindrome(long number)
        {
            for (int i = 0; i <= number.ToString().Length - 1; i++)
            {
                if (number.ToString()[i] != number.ToString()[number.ToString().Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
