using System;
using System.Linq;


namespace RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ');
            var last = words[words.Length - 1];
            var result = new string[words.Length];
            result[0] = last;
            for (int i = 0; i < words.Length - 1; i++)
            {
                result[i + 1] = words[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
