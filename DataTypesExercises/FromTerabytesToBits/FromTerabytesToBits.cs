using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            decimal teraByte = 1024 * 1024;
            teraByte *= (1024 * 1024) * 8;
            decimal resultBits = teraByte * input;
            Console.WriteLine(Math.Round(resultBits));
        }
    }
}
