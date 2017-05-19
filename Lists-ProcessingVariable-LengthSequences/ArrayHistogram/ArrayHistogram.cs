using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main()
        {
            var array = Console.ReadLine().Split();
            var result = new List<string>();
            int elements = array.Length;
            CountEveryWord(array, result, elements);
            bool isSmaller = false;
            isSmaller = SortingList(result);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static bool SortingList(List<string> result)
        {
            bool isSmaller;
            do
            {
                isSmaller = false;
                for (int i = 0; i < result.Count - 1; i++)
                {
                    var first = result[i].Split(' ');
                    int digit = int.Parse(first[2]);
                    var second = result[i + 1].Split(' ');
                    int secondDigit = int.Parse(second[2]);

                    if (digit < secondDigit)
                    {
                        string temp = result[i];
                        result[i] = result[i + 1];
                        result[i + 1] = temp;
                        isSmaller = true;
                    }

                }
            } while (isSmaller);
            return isSmaller;
        }

        private static void CountEveryWord(string[] array, List<string> result, int elements)
        {
            for (int i = 0; i < array.Length; i++)
            {
                double percent = 0.00;
                int count = 1;
                string format = string.Empty;
                if (array[i] == null) { continue; }

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == null) { continue; }

                    if (array[i].Equals(array[j]))
                    {
                        count++;
                        array.SetValue(null, j);
                    }
                }
                percent = ((double)count / elements) * 100;
                format = $"{array[i]} -> {count} times ({percent:f2}%)";
                result.Add(format);
            }
        }
    }
}
