using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main()
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            double volume = Math.Pow(cubeSide, 3);
            double surfaceArea = 6 * Math.Pow(cubeSide, 2);
            CalculateCubeParameters(faceDiagonal, spaceDiagonal, volume, surfaceArea, parameter);
        }

         static void CalculateCubeParameters(double faceDiagonal, double spaceDiagonal, double volume, double surfaceArea, string parameter)
        {
            switch (parameter)
            {
                case "face":
                    Console.WriteLine("{0:f2}", faceDiagonal);
                    break;
                case "space":
                    Console.WriteLine("{0:f2}", spaceDiagonal);
                    break;
                case "volume":
                    Console.WriteLine("{0:f2}", volume);
                    break;
                case "area":
                    Console.WriteLine("{0:f2}", surfaceArea);
                    break;
            }
        }
    }
}
