using System;
class BeerKegs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 3;
        string result = string.Empty;
        double maxSum = double.MinValue;
        int temp = 1;
        string tempResult = string.Empty;
        string model = string.Empty;
        double radius = 0;
        int height = 0;

        for (int i = 1; i <= 3 * n; i++)
        {
            if (temp == 1) { model = Console.ReadLine(); tempResult = model; }
            if (temp == 2) {  radius = double.Parse(Console.ReadLine()); }
            if (temp == 3) {  height = int.Parse(Console.ReadLine()); }

            temp++;

            if (count == i)
            {
                count = i;
                count += 3;
                temp = 1;
                double sum = Math.PI * (radius * radius) * height;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    result = tempResult;
                }
            }
        }

        Console.WriteLine(result);
    }
}
