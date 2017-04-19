using System;


namespace IntegerToBase
{
    class IntegerToBase
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            string result = IntegerBase(number, toBase);
            Console.WriteLine(result);
        }

         static string IntegerBase(int number, int toBase)
        {
            string result = string.Empty;
            
            while (number > 0)
            {
                int reminder = number % toBase;
                result = reminder + result;
                number /= toBase;
            }
            return result;
        }
    }
}
