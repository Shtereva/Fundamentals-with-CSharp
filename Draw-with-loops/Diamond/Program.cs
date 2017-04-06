using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int paddings = (n - 1) / 2;
            for (int i = 0; i <= (n - 1) / 2; i++)
            {
                Console.Write(new string('-', paddings));
                Console.Write("*");
                int mid = n - 2 * paddings - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', n - 2 * paddings - 2));
                    Console.Write('*');
                }
                Console.WriteLine(new string('-', paddings));
                paddings--;
            }
            paddings++;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                paddings++;
                Console.Write(new string('-', paddings));
                Console.Write("*");
                int mid = n - 2 * paddings - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', n - 2 * paddings - 2));
                    Console.Write('*');
                }
                Console.WriteLine(new string('-', paddings));
            }
        }
    }
}
