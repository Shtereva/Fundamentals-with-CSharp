using System;


namespace CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area =  CalculateAreaOfTriangle(width, height);
            Console.WriteLine(area);
        }

         static double CalculateAreaOfTriangle(double width, double height)
        {
            return width * (height / 2); 
        }
    }
}
