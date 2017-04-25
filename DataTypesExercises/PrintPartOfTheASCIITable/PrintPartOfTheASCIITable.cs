using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfTheASCIITable
{
    class PrintPartOfTheASCIITable
    {
        static void Main()
        {
            int char1 = int.Parse(Console.ReadLine());
            int char2 = int.Parse(Console.ReadLine());
            for (int i = char1; i <= char2; i++)
            {
                Console.Write("{0} ", (char)(i));
            }
            Console.WriteLine();
        }
    }
}
