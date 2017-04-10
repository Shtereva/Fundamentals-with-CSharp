using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleFormations
{
    class TriangleFormations
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string result = null;
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Triangle is valid.");
                if ((a * a) + (b * b) == (c * c)) { result = "Triangle has a right angle between sides a and b"; }
                else if ((a * a) + (c * c) == (b * b)) { result = "Triangle has a right angle between sides a and c"; }
                else if ((b * b) + (c * c) == (a * a)) { result = "Triangle has a right angle between sides b and c"; }
                else { Console.WriteLine("Triangle has no right angles"); }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
