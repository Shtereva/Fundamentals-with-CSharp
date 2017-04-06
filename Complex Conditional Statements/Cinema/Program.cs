using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            switch (typeProjection)
            {
                case "premiere":
                    Console.WriteLine("{0:f2} leva", (rows * columns) * 12.00);
                    break;
                case "normal":
                    Console.WriteLine("{0:f2} leva", (rows * columns) * 7.50);
                    break;
                case "discount":
                    Console.WriteLine("{0:f2} leva", (rows * columns) * 5.00);
                    break;

                default:
                    break;
            }
        }
    }
}
