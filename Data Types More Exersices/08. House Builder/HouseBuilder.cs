using System;
class HouseBuilder
{
    static void Main()
    {
        int materialOne = int.Parse(Console.ReadLine());
        int materialTwo = int.Parse(Console.ReadLine());

        int sByte = 0;
        int integer = 0;

        if (materialOne > sbyte.MaxValue  && materialOne <= int.MaxValue)
        {
            integer = materialOne;
            sByte = materialTwo;
        }

        else
        {
            integer = materialTwo;
            sByte = materialOne;
        }

        long sum = 10 * (long)integer;
        Console.WriteLine(sum + (4 * sByte));
    }
}
