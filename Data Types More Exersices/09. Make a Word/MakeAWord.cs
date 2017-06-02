using System;
class MakeAWord
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = string.Empty;

        for (int i = 0; i < n; i++)
        {
            char ch = char.Parse(Console.ReadLine());
            result += ch;
        }

        Console.WriteLine($"The word is: {result}");
    }
}
