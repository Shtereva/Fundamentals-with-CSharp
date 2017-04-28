using System;


namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(number);
            Console.WriteLine(isPrime);
        }

        private static bool IsPrime(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
