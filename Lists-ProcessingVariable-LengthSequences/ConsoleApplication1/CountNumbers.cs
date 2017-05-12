using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    class CountNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int counter = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != numbers.Count - 1)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        counter++;
                    }
                }
               
                 if(i == numbers.Count - 1 ||numbers[i] != numbers[i + 1])
                {
                    if (i == numbers.Count - 1)
                    {
                        Console.WriteLine($"{numbers[i]} -> {counter}");
                    }
                    else
                    {
                        Console.WriteLine($"{numbers[i]} -> {counter}");
                        counter = 1;
                    }
                }
                
            }
        }
    }
}
