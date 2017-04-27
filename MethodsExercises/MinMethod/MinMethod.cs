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
            GetMax(numberOne, numberTwo, numberThree);
        }

         static void GetMax(int numberOne, int numberTwo, int numberThree)
        {
            int compareFirstTwoNumbers = Math.Max(numberOne, numberTwo);
            int maxNumber = Math.Max(compareFirstTwoNumbers, numberThree);
            Console.WriteLine(maxNumber);
        }
    }
}
