using System;
using System.Collections.Generic;
using System.Linq;

namespace UnunionLists
{
    class UnunionLists
    {
        static void Main()
        {
            var primallList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                AddAndRemoveNumbers(primallList, sequence);
            }

            primallList.Sort();
            Console.WriteLine(string.Join(" ", primallList));
        }

        private static void AddAndRemoveNumbers(List<int> primalList, List<int> sequence)
        {
            for (int j = 0; j < sequence.Count; j++)
            {
                if (primalList.Contains(sequence[j]))
                {
                    primalList.RemoveAll(x => x == sequence[j]);
                }
                else
                {
                    primalList.Add(sequence[j]);
                }
            }
        }
    }
}
