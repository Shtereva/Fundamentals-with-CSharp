using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddSum = 0.0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;

            double evenSum = 0.0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum = evenSum + input;
                    if (evenMax < input)
                        evenMax = input;
                    if (evenMin > input)
                        evenMin = input;
                }
                else
                {
                    oddSum = oddSum + input;
                    if (oddMax < input)
                        oddMax = input;
                    if (oddMin > input)
                        oddMin = input;
                }
            }
                Console.WriteLine("OddSum=" + oddSum);
            if (oddMin == double.MaxValue)
                Console.WriteLine("OddMin=No");
            else
                Console.WriteLine("OddMin=" + oddMin);
            if (oddMax == double.MinValue)
                Console.WriteLine("OddMax=No");
            else
                Console.WriteLine("OddMax=" + oddMax);
                Console.WriteLine("EvenSum=" + evenSum);
            if(evenMin == double.MaxValue)
                Console.WriteLine("EvenMin=No");
            else
                Console.WriteLine("EvenMin=" + evenMin);
            if(evenMax == double.MinValue)
                Console.WriteLine("EvenMax=No");
            else
                Console.WriteLine("EvenMax=" + evenMax);

        }
    }
}
