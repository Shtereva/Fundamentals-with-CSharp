using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Reverse_String
{
    class ReverseString
    {
        static void Main()
        {
            var text = Console.ReadLine();
            Console.WriteLine(string.Join("", text.ToCharArray().Reverse()));
        }
    }
}
