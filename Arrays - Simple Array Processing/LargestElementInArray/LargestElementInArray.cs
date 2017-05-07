using System;
using System.Linq;


namespace LargestElementInArray
{
    class LargestElementInArray
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            int element = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > element)
                {
                    element = array[i];
                }
            }

            Console.WriteLine(element);
        }
    }
}
