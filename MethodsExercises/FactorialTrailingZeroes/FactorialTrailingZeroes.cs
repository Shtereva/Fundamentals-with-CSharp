using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int j = n; j > 1; j--)
            {
                factorial *= j;
            }

            BigInteger countZero = GetCountZero(factorial);
            Console.WriteLine(countZero);
        }

         static BigInteger GetCountZero(BigInteger factorial)
        {
            int counter = 0;
            for (BigInteger i = factorial; i >= 1; i--)
            {
                if (factorial % 10 == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                factorial /= 10;
            }
            return counter;
        }
    }
}
