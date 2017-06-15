using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Boxes
{
    public class Box
    {

        public static int CalculatePerimeter(int width, int height)
        {
            return (2 * width) + (2 * height);
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static double Distance(Point firsPoint, Point secondPoint)
        {
            double sideA = firsPoint.X - secondPoint.X;
            double sideB = firsPoint.Y - secondPoint.Y;
            double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return distance;
        }
    }

    public class Boxes
    {
        static void Main()
        {
            string input = Console.ReadLine();


            while (input != "end")
            {
                var line = input.Split(" |:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                Point firstPoint, secondPoint;

                UpperLeftAndRightPoint(line, out firstPoint, out secondPoint);
                double width = Point.Distance(firstPoint, secondPoint);

                UpperAndBottomLeft(line, out firstPoint, out secondPoint);
                double height = Point.Distance(firstPoint, secondPoint);

                int perimeter = Box.CalculatePerimeter((int)width, (int)height);
                int area = Box.CalculateArea((int)width, (int)height);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");

                input = Console.ReadLine();
            }

            
        }

        private static void UpperAndBottomLeft(string[] line, out Point firstPoint, out Point secondPoint)
        {
            firstPoint = new Point
            {
                X = int.Parse(line[0]),
                Y = int.Parse(line[1])
            };
            secondPoint = new Point
            {
                X = int.Parse(line[4]),
                Y = int.Parse(line[5])
            };
        }

        private static void UpperLeftAndRightPoint(string[] line, out Point firstPoint, out Point secondPoint)
        {
            firstPoint = new Point
            {
                X = int.Parse(line[0]),
                Y = int.Parse(line[1])
            };
            secondPoint = new Point
            {
                X = int.Parse(line[2]),
                Y = int.Parse(line[3])
            };
        }
    }
}
