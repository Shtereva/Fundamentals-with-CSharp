using System;
using System.Collections.Generic;
using System.Linq;
using _04.Distance_between_Points;

class DistanceBetweenPoints
{
    static void Main()
    {
        var first = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var second = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var firstPoint = new Point
        {
            X = first[0],
            Y = first[1]
        };

        var secPoint = new Point
        {
            X = second[0],
            Y = second[1]
        };

        double distance = Distance(firstPoint, secPoint);
        Console.WriteLine($"{distance:f3}");
    }

    public static double Distance(Point firsPoint, Point secondPoint)
    {
        double sideA = firsPoint.X - secondPoint.X;
        double sideB = firsPoint.Y - secondPoint.Y;
        double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));

        return distance;
    }
}
