using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStrings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string delimeter = (Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            string text = null;
            for (int i = 1; i <= number; i++)
            {
                string line = Console.ReadLine();
                text += line;
                if (i < number)
                {
                    text += delimeter;
                }
            }
            Console.WriteLine(text);
        }
    }
}
