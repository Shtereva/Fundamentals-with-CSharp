using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _04.Character_Multiplier
{
    class CharacterMultiplier
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var str1 = input[0].ToCharArray();
            var str2 = input[1].ToCharArray();
            int sum = 0;
            sum = CalculateSumOfChars(str1, str2);

            Console.WriteLine(sum);

        }

        private static int CalculateSumOfChars(char[] str1, char[] str2)
        {
            int sum;
            if (str1.Length <= str2.Length)
            {
                sum = str1
                    .Select(x => (int)x)
                    .Select((x, index) => str1[index] * str2[index])
                    .Sum();

                sum += str2
                    .Skip(str1.Length)
                    .Select(x => (int)x)
                    .Sum();
            }

            else
            {
                sum = str2
                    .Select(x => (int)x)
                    .Select((x, index) => str2[index] * str1[index])
                    .Sum();

                sum += str1
                    .Skip(str2.Length)
                    .Select(x => (int)x)
                    .Sum();
            }

            return sum;
        }
    }
}
