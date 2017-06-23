using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Text_Filter
{
    class TextFilter
    {
        static void Main()
        {
            var bannedWords = Console.ReadLine().Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
