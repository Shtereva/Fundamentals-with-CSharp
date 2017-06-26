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
            BigInteger num = input[1];
            var numToDigits = num.ToString().ToCharArray().Select(x => x.ToString()).Select(int.Parse).Reverse().ToArray();
            BigInteger result = 0;

            for (int i = 0; i < numToDigits.Length; i++)
            {
                BigInteger pow = 1;
                for (int j = 0; j < i; j++)
                {
                    pow *= baseNum;
                }
                result += numToDigits[i] * pow;

            }

            Console.WriteLine(result);
        }
    }
}
