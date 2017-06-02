using System;

class TouristInformation
{
    static void Main()
    {
        string imperialUnit = Console.ReadLine();
        double value = double.Parse(Console.ReadLine());

        switch (imperialUnit)
        {
            case "miles":
                Console.WriteLine($"{value} {imperialUnit} = {(double)(value) * 1.6:f2} kilometers");
                break;
            case "inches":
                Console.WriteLine($"{value} {imperialUnit} = {(double)(value) * 2.54:f2} centimeters");
                break;
            case "feet":
                Console.WriteLine($"{value} {imperialUnit} = {(double)(value) * 30d:f2} centimeters");
                break;
            case "yards":
                Console.WriteLine($"{value} {imperialUnit} = {(double)(value) * 0.91:f2} meters");
                break;
            case "gallons":
                Console.WriteLine($"{value} {imperialUnit} = {(double)(value) * 3.8:f2} liters");
                break;
        }
    }
}
