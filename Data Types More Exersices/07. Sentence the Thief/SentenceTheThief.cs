using System;
class CatchTheThief
{
    static void Main()
    {
        string thiefIDType = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        long max = 0;
        long maxNumber = long.MinValue;
        double sentence = 0;

        max = GetType(thiefIDType, max);

        for (int i = 0; i < n; i++)
        {
            long id = long.Parse(Console.ReadLine());
            if (id > maxNumber && id <= max)
            {
                maxNumber = id;
            }
        }

        if (maxNumber >= 0)
        {
            sentence = maxNumber / 127.0;
            sentence = Math.Ceiling(sentence);
        }

        else
        {
            sentence = maxNumber / -128.0;
            sentence = Math.Ceiling(sentence);
            sentence = Math.Abs(sentence);
        }
        Console.WriteLine(sentence > 1 ? $"Prisoner with id {maxNumber} is sentenced to {sentence} years" : $"Prisoner with id {maxNumber} is sentenced to {sentence} year");
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
