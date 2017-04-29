using System;
using System.Numerics;


namespace Factorial
{
    class Factorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int j = n; j > 1; j--)
                {
                    factorial *= j;
                }

            Console.WriteLine(factorial);
        }
    }
}
