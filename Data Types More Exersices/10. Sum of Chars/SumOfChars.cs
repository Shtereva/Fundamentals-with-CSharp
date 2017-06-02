using System;
class SumOfChars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            result += letter;
        }

        Console.WriteLine($"The sum equals: {result}");
    }
}
