using System;
using System.Linq;


namespace SumArrayElements
{
    class SumArrayElements
    {
        static void Main()
        {
            //var text = "1 2 3  4 ";
            //var parts = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
              

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                array[i] = digit;
                //sum += array[i];
            }
            Console.WriteLine(string.Join(Environment.NewLine, array));

            foreach (var digit in array)
            {
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
