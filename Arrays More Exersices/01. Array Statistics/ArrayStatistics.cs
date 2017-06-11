using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split();

        int[] array = new int[numbers.Length];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(numbers[i]);
        }
        Console.WriteLine("Min = " + array.Min());
        Console.WriteLine("Max = " + array.Max());
        Console.WriteLine("Sum = " + array.Sum());
        Console.WriteLine("Average = " + array.Average());
    }
}
