using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _2.Line_Numbers
{
    class LineNumbers
    {
        static void Main()
        {
            var input = File.ReadAllLines("input.txt").Select((x, index) => $"{++index}. {x}").ToArray();

            
           File.WriteAllLines("result.txt", input);
        }
    }
}
