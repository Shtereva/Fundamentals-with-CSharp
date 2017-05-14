using System;
using System.Collections.Generic;
using System.Linq;

namespace Winecraft
{
    class Winecraft
    {
        static void Main()
        {
            var grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int growthDays = int.Parse(Console.ReadLine());
            int rounds = 0;

            while (grapes.Count >= growthDays)
            {
                IncrementAllGrapes(grapes, ref rounds);
                RemoveSmallerGrapes(grapes, growthDays,ref rounds);
            }

            Console.WriteLine(string.Join(" ", grapes));
        }

        private static void RemoveSmallerGrapes(List<int> grapes, int growthDays,ref int rounds)
        {
            if (rounds == growthDays)
            {
                for (int i = 0; i < grapes.Count; i++)
                {
                    if (grapes[i] <= growthDays)
                    {
                        grapes.RemoveAt(i);
                        i--;
                    }
                }
                rounds = 0;
            }
        }

        private static void IncrementAllGrapes(List<int> grapes, ref int rounds)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                grapes[i]++; 
            }

            for (int j = 1; j < grapes.Count - 1; j++)
            {
                if (grapes[j] > grapes[j - 1] && grapes[j] > grapes[j + 1])
                {
                    grapes[j]--;  
                        if (grapes[j - 1] > 0) { grapes[j - 1] = Math.Max(grapes[j - 1] - 2, 0); grapes[j]++;  }
                        if (grapes[j + 1] > 0) { grapes[j + 1] = Math.Max(grapes[j + 1] - 2, 0); grapes[j]++; }
                }
            }
            rounds++;
        }
    }
}
