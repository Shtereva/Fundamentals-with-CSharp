using System;
class DecryptingMessage
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string result = string.Empty;

        for (int i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            int sum = letter + key;
            result += (char)sum;
        }

        Console.WriteLine(result);
    }
}
