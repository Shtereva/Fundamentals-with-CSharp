﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeter
{
    class CirclePerimeter
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter =  Math.PI * r * r;
            Console.WriteLine("{0:f12}", perimeter);
        }
    }
}