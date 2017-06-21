using System;
using System.Collections.Generic;
using System.IO;

namespace _1.Odd_Lines
{
    class OddLines
    {
        static void Main()
        {
            var file = "myfile.txt";

            var fileToRead = "Input.txt";

            var result = File.ReadAllLines(fileToRead);
            var oddPossitions = new List<string>();

            for (int i = 0; i < result.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddPossitions.Add(result[i]);
                }
            }


            File.AppendAllLines(file, oddPossitions);
        }
    }
}
