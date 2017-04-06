using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var oddSumm = 0.00;
            var evenSum = 0.00;
            
            for (int i = 1; i <= n; i++)
            {
                    if (i % 2 == 0)
                    {
                    evenSum = evenSum + double.Parse(Console.ReadLine());
                        
                    }

                    else
                    {
                    oddSumm = oddSumm + double.Parse(Console.ReadLine());
                    }
                }

            var difference = Math.Abs(evenSum - oddSumm);
            if (evenSum == oddSumm)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + oddSumm);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+ difference);
            }
        }
    }
}
