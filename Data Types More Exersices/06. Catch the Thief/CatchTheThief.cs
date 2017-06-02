using System;
    class CatchTheThief
{
    static void Main()
    {
        string thiefIDType = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        long max = 0;
        long maxNumber = long.MinValue;

        max = GetType(thiefIDType, max);

        for (int i = 0; i < n; i++)
        {
            long id = long.Parse(Console.ReadLine());
            if (id > maxNumber && id <= max)
            {
                maxNumber = id;
            }
        }

        Console.WriteLine(maxNumber);
    }

    private static long GetType(string thiefIDType, long max)
    {
        switch (thiefIDType)
        {
            case "sbyte":
                max = sbyte.MaxValue;
                break;
            case "int":
                max = int.MaxValue;
                break;
            case "long":
                max = long.MaxValue;
                break;
        }

        return max;
    }
}
