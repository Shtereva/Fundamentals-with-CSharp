using System;

namespace CountOfNegativeElementsInArray
{
    class CountOfNegativeElementsInArray
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
