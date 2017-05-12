using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main()
        {
            var blacklistedWords = Console.ReadLine().Split(' ').ToList();
            var fileNames = Console.ReadLine();
            var result = new List<string>();

            while (fileNames != "end")
            {
                bool containedWord = false;
                containedWord = AddTracks(blacklistedWords, fileNames, result, containedWord);
                fileNames = Console.ReadLine();
            }
            result.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static bool AddTracks(List<string> blacklistedWords, string fileNames, List<string> result, bool containedWord)
        {
            for (int i = 0; i < blacklistedWords.Count; i++)
            {
                if (fileNames.Contains(blacklistedWords[i]))
                {
                    containedWord = true;
                    break;
                }
            }

            if (containedWord == false)
            {
                result.Add(fileNames);
            }

            return containedWord;
        }
    }
}
