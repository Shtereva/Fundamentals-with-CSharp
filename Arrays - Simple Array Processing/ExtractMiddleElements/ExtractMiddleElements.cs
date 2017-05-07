using System;
using System.Linq;

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            ExtractElements(numbers);
        }

         static void ExtractElements(int[] numbers)
        {
            int count = numbers.Count();
            if (count == 1)
            {
                Console.WriteLine("{ " + $"{numbers[0]}" + " }");
            }

            if (count % 2 == 0)
            {
                int firstElemet = (count / 2) - 1;
                int secondElement = count / 2;
                Console.WriteLine("{ " + $"{numbers[firstElemet]}, {numbers[secondElement]}" + " }");
            }

            if (count % 2 != 0 && count != 1)
            {
                int firstElemet = (count / 2) - 1;
                int secondElement = count / 2;
                int thirdElement = (count / 2) + 1;
                Console.WriteLine("{ " + $"{numbers[firstElemet]}, {numbers[secondElement]}, {numbers[thirdElement]}" + " }");
            }
        }
    }
}
