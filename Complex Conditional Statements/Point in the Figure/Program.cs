using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 3 * h;
            int y1 = h;
            int x2 = h;
            int y2 = 4 * h;
            if (x > 0 && x< x1 && y > 0 && y< y1)
            {
                Console.WriteLine("Inside");
            }
            else if (x > h && x < 2*h && y > 0 && y < y2)
            {
                Console.WriteLine("Inside");
            }
            else if (x >= 0 && x <= 3*h && y >= 0 && y <= h)
            {
                Console.WriteLine("Border");
            }
            else if (x >= h && x <= 2 * h && (y == 0 || (y >= h && y <= 4 * h)))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Outside");
            }
            
        }
    }
}
