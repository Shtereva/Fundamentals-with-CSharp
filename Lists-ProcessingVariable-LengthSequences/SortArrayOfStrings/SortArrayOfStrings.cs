using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArrayOfStrings
{
    class SortArrayOfStrings
    {
        static void Main()
        {
            var strings = Console.ReadLine().Split();
            bool isBigger = false;
            do
            {
                isBigger = false;
                for (int i = 0; i < strings.Length - 1; i++)
                {
                    string first = strings[i];
                    string second = strings[i + 1];
                    int compaired = first.CompareTo(second);
                    if (first.CompareTo(second) > 0)
                    {
                        string temp = strings[i];
                        strings[i] = strings[i + 1];
                        strings[i + 1] = temp;
                        isBigger = true;
                    }
                }
            } while (isBigger);
            

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
