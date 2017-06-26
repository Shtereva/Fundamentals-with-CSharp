using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01.Convert_from_base_10_to_base_N
{
    class ConvertFromBase10TobaseN
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger baseNum = input[0];
            BigInteger decimalNum = input[1];
            var result = new List<string>();

            while (decimalNum > 0)
            {
                if (baseNum <= 0)
                {
                    break;
                }
                BigInteger reminder = decimalNum % baseNum;
                result.Add(reminder.ToString());
                decimalNum /= baseNum;
            }

            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
