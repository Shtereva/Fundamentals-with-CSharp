using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Morse_Code_Upgraded
{
    class MorseCodeUpgraded
    {
        static void Main()
        {
            var input = Console.ReadLine().Split("|".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

            long sum = 0;

            var result = new StringBuilder();

            foreach (var item in input)
            {
                var ones = Regex.Matches(item, @"1").Count;
                var zeroes = Regex.Matches(item, @"0").Count;

                sum = (ones * 5) + (zeroes * 3);

                var seqOnes = Regex.Matches(item, @"1{2,}").Cast<Match>().Select(x => x.Value.Length).Sum();
                var seqZeroes = Regex.Matches(item, @"0{2,}").Cast<Match>().Select(x => x.Value.Length).Sum();

                sum += seqOnes + seqZeroes;
                
                result.Append((char) sum);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
