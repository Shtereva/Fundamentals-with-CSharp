using System;
class BalancedBrackets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var brackets = string.Empty;

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            if (line == "(" || line == ")")
            {
                brackets += line;
            }
        }

        bool isBalanced = true;

        for (int i = 0; i < brackets.Length - 1; i += 2)
        {
            if (brackets[i] == '(' && brackets[i + 1] == ')' && brackets.Length % 2 == 0)
            {
                continue;
            }

            else
            {
                isBalanced = false;
                break;
            }
        }

        Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");
    }
}
