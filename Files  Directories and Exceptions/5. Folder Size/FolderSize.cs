using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _5.Folder_Size
{
    class FolderSize
    {
        static void Main()
        {
            var totalLenght = Directory
                .GetFiles("TestFolder")
                .Select(x => new FileInfo(x))
                .Sum(x => x.Length);

            Console.WriteLine(totalLenght / 1024.0 / 1024.0);
        }
    }
}
