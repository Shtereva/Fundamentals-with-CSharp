using System;
using System.Linq;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main()
        {
            long inputNumber = long.Parse(Console.ReadLine());
            var array = new bool[inputNumber + 1];
            array[0] = false;
            array[1] = false;

            for (long i = 2; i < array.Length; i++)
            {
               array[i] = true; 
            }

            for (long i = 2; i <= Math.Sqrt(inputNumber); i++)
            {
                if (array[i])
                {
                    for (long j = i * i; j <= inputNumber; j += i)
                    {
                        array[j] = false;
                    }
                }
            }

            for (long i = 0; i < array.Length; i++)
            {
                if (array[i] == true)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
