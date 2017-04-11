using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string numberHex = Console.ReadLine();
            int output = Convert.ToInt32(numberHex, 16);
            Console.WriteLine(output);
        }
    }
}
