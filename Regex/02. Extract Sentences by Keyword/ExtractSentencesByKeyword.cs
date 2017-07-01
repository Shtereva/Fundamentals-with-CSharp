using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Extract_Sentences_by_Keyword
{
    class ExtractSentencesByKeyword
    {
        static void Main()
        {
            var regexSplit = new Regex(@"\?|!|\.");
            var key = Console.ReadLine();

            var text = regexSplit.Split(Console.ReadLine().Trim()).Select(x => x.Trim()).ToArray();

            var pattern = $"\\W{key}\\W";
            var regex = new Regex(pattern);
            var result = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (regex.IsMatch(text[i]))
                {
                    result.Add(text[i]);
                }
            }

            result.ForEach(Console.WriteLine);
        }
    }
}
