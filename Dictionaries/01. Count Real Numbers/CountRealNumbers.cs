using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class CountRealNumbers
    {
        static void Main()
        {
            var words = Console.ReadLine().ToLower().Split().ToList();
            var ocurrences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!ocurrences.ContainsKey(word))
                {
                    ocurrences[word] = 0;
                }

                ocurrences[word]++;
            }

            words.Clear();

            foreach (var kvp in ocurrences)
            {
                if (kvp.Value % 2 != 0)
                {
                    words.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
