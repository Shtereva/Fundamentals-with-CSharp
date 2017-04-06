using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int biggestNumber = int.MinValue;
            int sumNumbers = 0;
            for (int i = 0; i < input; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
                sumNumbers = sumNumbers + number;
            }
            if (sumNumbers == biggestNumber * 2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + biggestNumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(biggestNumber - (sumNumbers - biggestNumber)));
            }
        }
    }
}
