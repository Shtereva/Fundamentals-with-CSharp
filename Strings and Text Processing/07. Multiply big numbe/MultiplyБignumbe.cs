using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.Multiply_big_numbe
{
    class MultiplyБignumbe
    {
        static void Main()
        {
            var number = Console.ReadLine().TrimStart('0').Select(x => x.ToString()).ToArray();
            var multiplier = Console.ReadLine().TrimStart('0');
            if (number.Length == 0 || multiplier == string.Empty)
            {
                Console.WriteLine(0);
                return;
            }

            var result = new StringBuilder();
            int reminder = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int temp = int.Parse(multiplier) * int.Parse(number[i]);
                temp += reminder;

                if (i > 0)
                {
                    result.Append(temp % 10);
                    reminder = temp / 10;
                }

                else
                {
                    result.Append(new string(temp.ToString().Reverse().ToArray()));
                }
            }

            string numToString = new string(result.ToString().Reverse().ToArray());
            Console.WriteLine(numToString);
        }
    }
}
