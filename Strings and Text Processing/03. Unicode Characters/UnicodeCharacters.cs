using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Unicode_Characters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            Console.WriteLine(string.Join("", input.Select(x => (int)x).Select(x => $"\\u{x:x4}")));
        }
    }
}
