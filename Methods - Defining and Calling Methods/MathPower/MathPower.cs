using System;


namespace MathPower
{
    class MathPower
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = NumberRaisedToPower(number, power);
            Console.WriteLine(result);
        }

         static double NumberRaisedToPower(double number, int power)
        {
            double result = 1; ;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
