using System;
using System.Linq;


namespace CharRotation
{
    class CharRotation
    {
        static void Main()
        {
            var symbols = Console.ReadLine().ToCharArray();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string output = string.Empty;

            for (int i = 0; i < symbols.Length; i++)
            {
                int sum = 0;
                if (numbers[i] % 2 == 0)
                {
                    sum = symbols[i] - numbers[i];
                    output += (char)sum;
                }
                else
                {
                    sum = symbols[i] + numbers[i];
                    output += (char)sum;
                }
            }

            Console.WriteLine(output);
        }
    }
}
