using System;


namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            string output = Convert.ToString(number);
            PrintReversedNumbers(output);

        }

         static void PrintReversedNumbers(string output)
        {
            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            Console.WriteLine();
        }
    }
}
