using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                var firstIndex = text.IndexOf(pattern);
                var lastIndex = text.LastIndexOf(pattern);

                if (firstIndex >= 0 && lastIndex >= 0 && firstIndex != lastIndex && pattern.Length > 0)
                {
                    text = text.Remove(lastIndex, pattern.Length);
                    text = text.Remove(firstIndex, pattern.Length);

                    Console.WriteLine("Shaked it.");

                    int patternIndex = pattern.Length / 2;
                    pattern = pattern.Remove(patternIndex, 1);
                }

                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    break;
                }
            }
        }
    }
}
