using System;
using System.Linq;


namespace MultiplyAnArrayOfDoubles
{
    class MultiplyAnArrayOfDoubles
    {
        static void Main()
        {
            var doubles = Console.ReadLine().Split(' ');
            var arr = new double[doubles.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(doubles[i]);
            }

            double multiply = double.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= multiply;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
