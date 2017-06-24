using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace _04.Punctuation_Finder
{
    class Program
    {
        static void Main()
        {
            var text = File.ReadAllLines(
                "C:\\Users\\Kimi\\Desktop\\10. Programming-Fundamentals-Objects-Classes-Files-and-Exceptions-More-Exercises-Resources\\sample_text.txt")
                .ToArray();

           var punctuations = new List<char>();
            var wordsOnly = new List<string>();
            foreach (var word in text)
            {
                var chars = word.ToCharArray().Where(x => x == '.' || x == ',' || x == '!' || x == '?' || x == ':').ToArray();
                punctuations.AddRange(chars);

                var words = word.Split(".,!?:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                wordsOnly.AddRange(words);
            }

            string output = string.Join(", ", punctuations);
            File.WriteAllText("output.txt", output);
            File.WriteAllLines("output2.txt", wordsOnly);
            Console.WriteLine(string.Join(Environment.NewLine, wordsOnly));
        }
    }
}
