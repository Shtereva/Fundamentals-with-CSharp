using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}| ", new string(' ', n + 1) );
            for (int i = 1; i <= n; i++)
            {
                string stars = new string('*', i);
                string spaces = new string(' ', n - i);
                Console.Write(spaces);
                Console.Write(stars);
                Console.Write(" | ");
                Console.Write(stars);
                Console.WriteLine();
            }
        }
    }
}
