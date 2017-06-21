using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _4.Merge_Files
{
    class MergeFiles
    {
        static void Main()
        {
            var numbers = File.ReadAllLines("FileOne.txt")
                .Concat(File.ReadAllLines("FileTwo.txt"))
                .OrderBy(x => x)
                .ToArray();

            File.WriteAllLines("output.txt", numbers);

            
        }
    }
}
