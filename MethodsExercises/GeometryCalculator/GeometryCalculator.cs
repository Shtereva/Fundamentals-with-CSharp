using System;


namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main()
        {
            string typeOfFigure = Console.ReadLine().ToLower();
            PrintAreaOfFigure(typeOfFigure);
        }

         static void PrintAreaOfFigure(string typeOfFigure)
        {
            switch (typeOfFigure)
            {
                case "triangle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        double area = (side * height) / 2;
                        Console.WriteLine("{0:f2}", area);
                        break;
                    }
                case "square":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double area = Math.Pow(side, 2);
                        Console.WriteLine("{0:f2}", area);
                        break;
                    }
                case "rectangle":
                    {
                        double width = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        double area = width * height;
                        Console.WriteLine("{0:f2}", area);
                        break;
                    }
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        double area = Math.PI * Math.Pow(radius, 2);
                        Console.WriteLine("{0:f2}", area);
                        break;
                    }
            }
        }
    }
}
