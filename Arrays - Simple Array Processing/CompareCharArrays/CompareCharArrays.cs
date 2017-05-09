using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            var arrayOne = Console.ReadLine().Split();
            var arrayTwo = Console.ReadLine().Split();
            int lenghts = Math.Min(arrayOne.Length, arrayTwo.Length);
            bool equals = true;
            int index = 0;
            equals = CheckEquals(arrayOne, arrayTwo, lenghts, equals, index);
            PrintLexicographicly(arrayOne, arrayTwo, equals, index);

        }

        private static void PrintLexicographicly(string[] arrayOne, string[] arrayTwo, bool equals, int index)
        {
            if (equals)
            {
                if (arrayOne.Length >= arrayTwo.Length)
                {
                    Console.WriteLine(string.Join("", arrayTwo));
                    Console.WriteLine(string.Join("", arrayOne));
                }
                else
                {
                    Console.WriteLine(string.Join("", arrayOne));
                    Console.WriteLine(string.Join("", arrayTwo));
                }
            }
            else
            {
                char one = char.Parse(arrayOne[index]);
                char two = char.Parse(arrayTwo[index]);
                if (one <= two)
                {
                    Console.WriteLine(string.Join("", arrayOne));
                    Console.WriteLine(string.Join("", arrayTwo));
                }
                else
                {
                    Console.WriteLine(string.Join("", arrayTwo));
                    Console.WriteLine(string.Join("", arrayOne));
                }
            }
        }

        private static bool CheckEquals(string[] arrayOne, string[] arrayTwo, int lenghts, bool equals, int index)
        {
            for (int i = 0; i < lenghts; i++)
            {
                if (arrayOne[i].Equals(arrayTwo[i]))
                {
                    continue;
                }
                else
                {
                    index = i;
                    equals = false;
                    break;
                }
            }

            return equals;
        }
    }
}
