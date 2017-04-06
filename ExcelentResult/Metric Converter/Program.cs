using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist = double.Parse(Console.ReadLine());
            string unitInput = Console.ReadLine();
            string unitOutput = Console.ReadLine();

            double meters = 1;

            if (unitInput == "m")
            {
                meters = meters * dist;
            }
            else if (unitInput == "mm")
            {
                meters = dist / 1000; 
            }
            else if(unitInput == "cm")
            {
                meters = dist / 100;
            }
            else if (unitInput == "mi")
            {
                meters = dist / 0.000621371192;
            }
            else if (unitInput == "in")
            {
                meters = dist / 39.3700787;
            }
            else if (unitInput == "km")
            {
                meters = dist / 0.001;
            }
            else if (unitInput == "ft")
            {
                meters = dist / 3.2808399;
            }
            else if (unitInput == "yd")
            {
                meters = dist / 1.0936133;
            }

            if (unitOutput == "m")
            {
                Console.WriteLine("{0} {1}", meters, unitOutput);
            }
            else if(unitOutput == "mm")
            {
                Console.WriteLine("{0} {1}", meters * 1000, unitOutput);
            }
            else if (unitOutput == "cm")
            {
                Console.WriteLine("{0} {1}", meters * 100, unitOutput);
            }
            else if (unitOutput == "mi")
            {
                Console.WriteLine("{0} {1}", meters * 0.000621371192, unitOutput);
            }
            else if (unitOutput == "in")
            {
                Console.WriteLine("{0} {1}", meters * 39.3700787, unitOutput);
            }
            else if (unitOutput == "km")
            {
                Console.WriteLine("{0} {1}", meters * 0.001, unitOutput);
            }
            else if (unitOutput == "ft")
            {
                Console.WriteLine("{0} {1}", meters * 3.2808399, unitOutput);
            }
            else if (unitOutput == "yd")
            {
                Console.WriteLine("{0} {1}", meters * 1.0936133, unitOutput);
            }
        }
    }
}