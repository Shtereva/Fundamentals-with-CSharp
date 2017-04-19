using System;


namespace MinMethod
{
    class MinMethod
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            GetMin(numberOne, numberTwo, numberThree);
        }

         static void GetMin(int numberOne, int numberTwo, int numberThree)
        {
            int compareFirstTwoNumbers = Math.Min(numberOne, numberTwo);
            int minNumber = Math.Min(compareFirstTwoNumbers, numberThree);
            Console.WriteLine(minNumber);
        }
    }
}
