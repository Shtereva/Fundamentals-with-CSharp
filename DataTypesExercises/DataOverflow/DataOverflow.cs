using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataOverflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            decimal numberOne = ulong.Parse(Console.ReadLine());
            decimal numberTwo = ulong.Parse(Console.ReadLine());
            string resultOne = null;
            string resultTwo = null;
            if (numberOne >= byte.MinValue && numberOne <= byte.MaxValue) { resultOne = "byte"; }
            else if (numberOne >= ushort.MinValue && numberOne <= ushort.MaxValue) { resultOne = "ushort"; }
            else if (numberOne >= uint.MinValue && numberOne <= uint.MaxValue) { resultOne = "uint"; }
            else if (numberOne >= ulong.MinValue && numberOne <= ulong.MaxValue) { resultOne = "ulong"; }

            if (numberTwo >= byte.MinValue && numberTwo <= byte.MaxValue) { resultTwo = "byte"; }
            else if (numberTwo >= ushort.MinValue && numberTwo <= ushort.MaxValue) { resultTwo = "ushort"; }
            else if (numberTwo >= uint.MinValue && numberTwo <= uint.MaxValue) { resultTwo = "uint"; }
            else if (numberTwo >= ulong.MinValue && numberTwo <= ulong.MaxValue) { resultTwo = "ulong"; }
            if (numberOne > numberTwo)
            {
                Console.WriteLine("bigger type: {0} ", resultOne);
                Console.WriteLine("smaller type: {0} ", resultTwo);
                Console.Write("{0} can overflow {1} ", numberOne, resultTwo);
                switch (resultTwo)
                {
                    case "byte": Console.WriteLine(Math.Round(numberOne / byte.MaxValue) + " times"); break;
                    case "ushort": Console.WriteLine(Math.Round(numberOne / ushort.MaxValue) + " times"); break;
                    case "uint": Console.WriteLine(Math.Round(numberOne / uint.MaxValue) + " times"); break;
                    case "ulong": Console.WriteLine(Math.Round(numberOne / ulong.MaxValue) + " times"); break;
                }
            }
            else
            {
                Console.WriteLine("bigger type: {0} ", resultTwo);
                Console.WriteLine("smaller type: {0} ", resultOne);
                Console.Write("{0} can overflow {1} ", numberTwo, resultOne);
                switch (resultOne)
                {
                    case "byte": Console.WriteLine(Math.Round(numberTwo / byte.MaxValue) + " times"); break;
                    case "ushort": Console.WriteLine(Math.Round(numberTwo / ushort.MaxValue) + " times"); break;
                    case "uint": Console.WriteLine(Math.Round(numberTwo / uint.MaxValue) + " times"); break;
                    case "ulong": Console.WriteLine(Math.Round(numberTwo / ulong.MaxValue) + " times"); break;
                }
            }
        }
    }
}
