using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            Printnumbers(5, 10);
            Printnumbers(15);
            Printnumbers();
            Printnumbers(start:35, end: 55);
        }

        private static void Printnumbers(int start = 0, int end = 100)
        {
            for (int i = start; i < end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
