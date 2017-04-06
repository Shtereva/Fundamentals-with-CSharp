using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");
                for (int c = 1; c <= i - 1; c++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string(' ', i));
                Console.Write("*");
                for (int c = 1; c < n - i ; c++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
