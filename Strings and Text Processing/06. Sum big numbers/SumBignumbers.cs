using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Sum_big_numbers
{
    class SumBignumbers
    {
        static void Main()
        {
            var line1 = Console.ReadLine().TrimStart('0').Select(x => x.ToString()).ToList();
            var line2 = Console.ReadLine().TrimStart('0').Select(x => x.ToString()).ToList();
            int zeroes = Math.Abs(line2.Count - line1.Count);

            SplitString(line1, line2, zeroes);

            line1.Reverse();
            line2.Reverse();

            var result = new StringBuilder();

            for (int i = 0; i < line1.Count; i++)
            {
                int temp = int.Parse(line1[i]) + int.Parse(line2[i]);

                if (temp < 10)
                {
                    result.Append(temp);
                }

                else
                {

                    if (i < line1.Count - 1)
                    {
                        result.Append(temp % 10);
                        line1[i + 1] = (int.Parse(line1[i + 1]) + 1).ToString();
                    }

                    else
                    {
                        result.Append(new string(temp.ToString().Reverse().ToArray()));
                    }
                }
            }

            var numToString = new string(result.ToString().Reverse().ToArray());

            Console.WriteLine(numToString);
        }

        private static void SplitString(List<string> line1, List<string> line2, int zeroes)
        {
            if (line1.Count < line2.Count)
            {
                for (int i = 0; i < zeroes; i++)
                {
                    line1.Insert(0, "0");
                }
            }

            else
            {
                for (int i = 0; i < zeroes; i++)
                {
                    line2.Insert(0, "0");
                }
            }
        }
    }
}
