using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Sentence_Split
{
    class SentenceSplit
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            Console.WriteLine($"[{text.Replace(pattern, ", ")}]");
        }
    }
}
