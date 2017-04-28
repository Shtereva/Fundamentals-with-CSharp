using System;


namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); ;
            Fib(n);
        }

        private static void Fib(int n)
        {
            int firstNumber = 1;
            int secondNumber = 0;
            int fibNumber = 0;
            for (int i = 0; i <= n; i++)
            {
                fibNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = fibNumber;
            }
            Console.WriteLine(fibNumber);

        }
    }
}
