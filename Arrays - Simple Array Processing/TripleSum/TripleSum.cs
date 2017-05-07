using System;
using System.Linq;


namespace TripleSum
{
    class TripleSum
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            bool hasMatch = false; 
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                        long sum = array[i] + array[j];
                        if (array.Contains(sum) && array[j] >= 0)
                        {
                            Console.WriteLine($"{array[i]} + {array[j]} == {sum}");
                            hasMatch = true;
                        }
                }
            }

            if (hasMatch == false) { Console.WriteLine("No"); }
        }
    }
}
