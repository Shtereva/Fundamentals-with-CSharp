using System;
using System.Linq;

namespace ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ');
            Console.WriteLine(string.Join(" ", array.Reverse()));
        }
    }
}
