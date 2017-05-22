using System;
using System.Collections.Generic;
using System.Linq;

namespace IncreasingCrisis
{
    class IncreasingCrisis
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var result = new List<int>();

            for (int i = 0; i < number; i++)
            {
                var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                if (i == 0)
                {
                    AddFirstSequence(result, sequence);
                    continue;
                }
                InsertElementsToResult(sequence, result);
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static void InsertElementsToResult(List<int> sequence, List<int> result)
        {
            int index = 0;
            int sequenceIndex = 0;
            bool smallerElement = false;
            for (int j = result.Count - 1; j >= index; j--)
            {
                if (result[j] <= sequence[sequenceIndex])
                {
                    index = j;
                    if (j == result.Count - 1)
                    {
                        result.Add(sequence[sequenceIndex]);
                        j = result.Count;
                        sequenceIndex++;
                    }

                    else
                    {
                        result.Insert(j + 1, sequence[sequenceIndex]);
                        sequenceIndex++;
                        j = result.Count;
                    }

                    index++;
                    
                    if (sequenceIndex == sequence.Count) { break; }
                    smallerElement = true;
                }

                if (smallerElement && sequence[sequenceIndex - 1] > sequence[sequenceIndex])
                {
                    result.RemoveRange(index + 1, result.Count - (index + 1));
                    break;
                }
            }
        }

        private static void AddFirstSequence(List<int> result, List<int> sequence)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                result.Add(sequence[i]);
            }
        }
    }
}
