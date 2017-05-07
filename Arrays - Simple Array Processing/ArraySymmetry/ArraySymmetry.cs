using System;

namespace ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main()
        {
            var text = Console.ReadLine().Split(' ');
            bool isSymetric = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    isSymetric = false;
                }
            }

            Console.WriteLine(isSymetric ? "Yes" : "No");
        }
    }
}
