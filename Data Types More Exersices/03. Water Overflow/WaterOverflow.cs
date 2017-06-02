using System;

class WaterOverflow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int currentCapacity = 0;
        for (int i = 0; i < n; i++)
        {
            int liters = int.Parse(Console.ReadLine());

            if (currentCapacity + liters <= 255)
            {
                currentCapacity += liters;
            }

            else
            {
                Console.WriteLine("Insufficient capacity!");
                continue;
            }
        }

        Console.WriteLine(currentCapacity);
    }
}
