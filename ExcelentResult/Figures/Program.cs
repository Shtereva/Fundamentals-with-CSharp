using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double number = double.Parse(Console.ReadLine());
                double liceSquare = Math.Round((number * number), 3);
                Console.WriteLine(liceSquare);
            }
            if (figure == "rectangle")
            {
                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());
                double liceRectangle = Math.Round((number1 * number2), 3);
                Console.WriteLine(liceRectangle);
            }
            if (figure == "circle")
            {
                double number3 = double.Parse(Console.ReadLine());
                double liceCircle = Math.Round(Math.PI * (number3 * number3), 3);
                Console.WriteLine(liceCircle);
            }
            if (figure == "triangle")
            {
                double number4 = double.Parse(Console.ReadLine());
                double number5 = double.Parse(Console.ReadLine());
                double liceTriangle = Math.Round((number4 * number5) / 2, 3);
                Console.WriteLine(liceTriangle);
            }
        }
    }
}
