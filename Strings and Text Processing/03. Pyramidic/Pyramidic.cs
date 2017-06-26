using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Pyramidic
{
    class Pyramidic
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var pyramidic = new List<string>();
            var lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    char currentCharacter = currentLine[j];
                    int layer = 1;
                    string currentPyramd = string.Empty;

                    for (int k = i; k < lines.Length; k++)
                    {
                        string currentLayer = new string(currentCharacter, layer);

                        if (lines[k].Contains(currentLayer))
                        {
                            currentPyramd += currentLayer + Environment.NewLine;
                        }

                        else
                        {
                            break;
                        }

                        layer += 2;
                    }

                    pyramidic.Add(currentPyramd.Trim());
                }
            }

            Console.WriteLine(pyramidic.OrderByDescending(x => x.Length).First());
        }
    }
}