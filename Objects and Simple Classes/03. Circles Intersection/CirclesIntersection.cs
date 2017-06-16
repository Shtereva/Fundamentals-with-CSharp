using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Circles_Intersection
{
    public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class CirclesIntersection
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var points = new Point()
            {
                X = input[0],
                Y = input[1]
            };

            var firstPoint = new Circle()
            {
                Center = new Point()
                {
                    X = points.X,
                    Y = points.Y
                },
                Radius = input[2]
            };

            var secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var secondPoints = new Point()
            {
                X = secondInput[0],
                Y = secondInput[1]
            };

            var secondPoint = new Circle()
            {
                Center = new Point()
                {
                    X = secondPoints.X,
                    Y = secondPoints.Y
                },
                Radius = secondInput[2]
            };

            double distance = CalculateDistance(firstPoint, secondPoint);

            bool intersect = Intersect(firstPoint, secondPoint, distance);

            Console.WriteLine(intersect ? "Yes" : "No");
        }

        private static bool Intersect(Circle firstPoint, Circle secondPoint, double distance)
        {
            if (distance <= firstPoint.Radius + secondPoint.Radius)
            {
                return true;
            }

            return false;
        }

        private static double CalculateDistance(Circle firstPoint, Circle secondPoint)
        {
            double sideA = firstPoint.Center.X - secondPoint.Center.X;
            double sideB = firstPoint.Center.Y - secondPoint.Center.Y;
            double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return distance;
        }
    }
}
