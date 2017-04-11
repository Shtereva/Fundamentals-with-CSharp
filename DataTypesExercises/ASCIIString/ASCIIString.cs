using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIString
{
    class ASCIIString
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = null; ;
            for (int i = 0; i < number; i++)
            {
                int chars = int.Parse(Console.ReadLine());
                text += (char)(chars);
            }
            Console.WriteLine(text);
        }
    }
}
