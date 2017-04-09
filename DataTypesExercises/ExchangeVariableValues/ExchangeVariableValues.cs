using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int oldNumber = b; 
            b = a; 
            a = oldNumber;
            Console.WriteLine(a);
            Console.WriteLine(b);
            
        }
    }
}
