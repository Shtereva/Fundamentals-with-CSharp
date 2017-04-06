using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            
                Console.WriteLine("Bigger number: " + num1);
            
            else
            
                Console.WriteLine("Bigger number: " + num2);
            // Console.WriteLine("Bigger number :", Math.Max(num1, num2))
            
        }
    }
}
