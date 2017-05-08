using System;
using System.Linq;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            var array = new bool[inputNumber];
            array[0] = false;
            array[1] = false;
            int smallestPrime = 2;

            for (int i = 2; i < array.Length; i++)
            {
               array[i] = true; 
                if (i == smallestPrime) { Console.WriteLine(smallestPrime); }
            }

            for (int i = 2; i < array.Length; i++)
            {
                if (i == smallestPrime * smallestPrime)
                {
                    array[i] = false;
                }
            }
        }
    }
}
