using System;


namespace DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSquare(n);
                 
        }

        private static void PrintSquare(int n)
        {
            PrintHeader(n);
            PrintMiddle(n);
            PrintHeader(n);
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
        static void PrintMiddle(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write(@"\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
