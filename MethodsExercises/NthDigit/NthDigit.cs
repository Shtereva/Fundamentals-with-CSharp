using System;


namespace NthDigit
{
    class NthDigit
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            int returnedDigit = FindNthDigit(number, index);
            Console.WriteLine(returnedDigit);
        }

         static int FindNthDigit(long number, int index)
        {
            for (int i = 1; i < index; i++)
            {
                long result = number / 10;
                number = result;
            }
            number = number % 10;
            return (int)number;
        }
    }
}
