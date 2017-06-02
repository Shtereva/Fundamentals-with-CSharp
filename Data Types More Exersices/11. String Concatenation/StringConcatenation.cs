using System;
class StringConcatenation
{
    static void Main()
    {
        char delimeter = char.Parse(Console.ReadLine());
        string evenOdd = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string result = string.Empty;

        for (int i = 1; i <= n; i++)
        {
            string line = Console.ReadLine();
            if (evenOdd == "even")
            {
                if (i % 2 == 0)
                {
                    result += line + delimeter;
                }
            }
            else
            {
                if (i % 2 != 0)
                {
                    result += line + delimeter;
                }
            }
        }

        result = result.Remove(result.Length - 1, 1);
        Console.WriteLine(result);
    }
}
