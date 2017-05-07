using System;

namespace LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int lastElements = int.Parse(Console.ReadLine());
            long[] array = new long[n];
            array[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                
                for (int j = i - lastElements; j <= i - 1; j++)
                {
                    if (j < 0)
                    {
                        j = j + Math.Abs(j);
                    }
                        sum += array[j];
                }
                array[i] = sum;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
