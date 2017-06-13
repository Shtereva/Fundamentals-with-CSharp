using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Closest_Two_Points
{
    class ClosestTwoPoints
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            var minValue = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var distance = Distance(points[i], points[j]);

                    if (distance < minValue)
                    {
                        minValue = distance;
                        firstPointResult = points[i];
                        secondPointResult = points[j];
                    }
                }
            }

            Console.WriteLine($"{minValue:f3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
        }

        public static double Distance(Point firsPoint, Point secondPoint)
        {
            double sideA = firsPoint.X - secondPoint.X;
            double sideB = firsPoint.Y - secondPoint.Y;
            double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return distance;
        }

        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }
    }
}
