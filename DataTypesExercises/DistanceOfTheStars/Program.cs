using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOfTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYearInKm = 9450000000000;
            decimal earthNearestStar = (decimal)4.22 * lightYearInKm;
            decimal earthCenterOfGalaxy = 26000 * lightYearInKm;
            decimal diameterMilkyWay = 100000 * lightYearInKm;
            decimal earthToEdgeOfUniverse = 46500000000 * lightYearInKm;
            Console.WriteLine(earthNearestStar.ToString("e2"));
            Console.WriteLine(earthCenterOfGalaxy.ToString("e2"));
            Console.WriteLine(diameterMilkyWay.ToString("e2"));
            Console.WriteLine(earthToEdgeOfUniverse.ToString("e2"));
        }
    }
}
