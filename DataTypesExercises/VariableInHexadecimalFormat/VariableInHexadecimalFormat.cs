using System;


namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            string numberHex = Console.ReadLine();
            int output = Convert.ToInt32(numberHex, 16);
            Console.WriteLine(output);
        }
    }
}
