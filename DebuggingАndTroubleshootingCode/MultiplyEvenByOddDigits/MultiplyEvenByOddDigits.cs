using System;


namespace MultiplyEvenByOddDigits
{
    class MultiplyEvenByOddDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int multipliedDigits = GetMultipleOfEvensAndOdds(Math.Abs(number));
            Console.WriteLine(multipliedDigits);
        }

         static int GetMultipleOfEvensAndOdds(int number)
        {
            int evenNumber = GetSumOfEvenDigits(number);
            int oddNumber = GetSumOfOddDigits(number);
            return evenNumber * oddNumber;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 != 0) { sum += currentDigit; }
                number /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 0) { sum += currentDigit; }
                number /= 10;
            }
            return sum;
        }
    }
}
