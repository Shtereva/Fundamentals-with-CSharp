using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _3.Word_Count
{
    class WordCount
    {
        static void Main()
        {
            var wordCount = new Dictionary<string, int>();

            var words = File.ReadAllText("words.txt").ToLower().Split();

            foreach (var word in words)
            {
                wordCount[word] = 0;
            }

            var input = File.ReadAllText("text.txt").ToLower().Split(" -,?!.\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var word in input)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            var result = wordCount
                .OrderByDescending(x => x.Value)
                .Select(x => $"{x.Key} - {x.Value}")
                .ToList();

            File.WriteAllLines("output.txt", result);
        }
    }
}
