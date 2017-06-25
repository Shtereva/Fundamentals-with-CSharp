using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Pyramidic
{
    class Pyramidic
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var pyramidic = new Dictionary<char, int>();
            int count = 3;

            for (int i = 0; i < n; i++)
            {
                var lines = Console.ReadLine();
                foreach (var letter in lines.ToCharArray())
                {
                    if (!pyramidic.ContainsKey(letter))
                    {
                        pyramidic[letter] = 1;
                    }
                }

                foreach (var letter in pyramidic)
                {
                    string pattern = new string(letter.Key, letter.Value + 2);
                    if (lines.Contains(pattern))
                    {
                        pyramidic[letter.Key] += 2;
                    }
                }
            }
        }
    }
}