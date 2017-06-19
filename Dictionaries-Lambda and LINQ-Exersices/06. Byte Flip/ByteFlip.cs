using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _06.Byte_Flip
{
    class ByteFlip
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Where(x => x.Length == 2)
                .Select(x => x.Reverse())
                .Select(x => string.Join("", x))
                .Reverse()
                .Select(x => Convert.ToInt32(x, 16))
                .ToList()
                .ForEach(x => Console.Write((char)x));

            Console.WriteLine();
        }
    }
}
