using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Placeholders
{
    class Placeholders
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var a = input.IndexOf("{}");

            while (input != "end")
            {
                var line = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                
                var sentence = line[0].Trim().Split();
                var values = line[1].Trim().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i].Contains("{") || sentence[i].Contains("}"))
                    {
                        var placeHolderOne = sentence[i].IndexOf("{");
                        var placeHolderTwo = sentence[i].IndexOf("}");
                        var digit = int.Parse(sentence[i].Substring(placeHolderOne + 1, placeHolderTwo - 1));
                        var textToReplace = sentence[i].Substring(placeHolderOne, placeHolderTwo + 1);
                        if (digit < values.Length)
                        {
                            sentence[i] = sentence[i].Replace(textToReplace, values[digit]);
                        }
                    }
                }

                Console.WriteLine(string.Join(" ", sentence));
                input = Console.ReadLine();
            }
        }
    }
}
