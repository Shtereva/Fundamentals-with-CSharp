using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(FindPrimesInRange(start, end));
            PrintPrimeIntegers(list);
        }

         static void PrintPrimeIntegers(List<int> list)
        {
            //list.Remove(0);
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    Console.WriteLine(list[i]);
                }
                else
                {
                    Console.Write(list[i] + ", ");
                }
            }
        }

        static List<int> FindPrimesInRange(int start, int end)
        {
            bool isPrime = true;
            List<int> list = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (i == 0 || i == 1) { continue; }
                if (i == 2)
                {
                    list.Add(i);
                    continue;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    list.Add(i);
                }

                isPrime = true;
            }
            return list;
        }
    }
}
