using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Rectangle_Position
{
    class RectanglePosition
    {
        static void Main()
        {
            var rectangleOne = ReadRectangle();
            var rectangleTwo = ReadRectangle();

            Console.WriteLine(rectangleOne.IsInside(rectangleTwo) ? "Inside" : "Not inside");
        }

        public static Rectangle ReadRectangle()
        {
            var rectangleParts = Console.ReadLine().Split().Select(long.Parse).ToArray();

            return new Rectangle
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
        }
    }
}
