using System;


namespace DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main()
        {
            string number = Console.ReadLine();
                try
                {
                    long.Parse(number);
                    GetNumberTypes(number);
                }

                catch (System.OverflowException ex)
                {
                    Console.WriteLine("{0} can't fit in any type", number);
                }    
        }

        static void GetNumberTypes(string number)
        {
            Console.WriteLine("{0} can fit in:", number);
            if (long.Parse(number) <= sbyte.MaxValue && long.Parse(number) >= sbyte.MinValue) { Console.WriteLine("* sbyte"); }
            if (long.Parse(number) <= byte.MaxValue && long.Parse(number) >= byte.MinValue) { Console.WriteLine("* byte"); }
            if (long.Parse(number) <= short.MaxValue && long.Parse(number) >= short.MinValue) { Console.WriteLine("* short"); }
            if (long.Parse(number) <= ushort.MaxValue && long.Parse(number) >= ushort.MinValue) { Console.WriteLine("* ushort"); }
            if (long.Parse(number) <= int.MaxValue && long.Parse(number) >= int.MinValue) { Console.WriteLine("* int"); }
            if (long.Parse(number) <= uint.MaxValue && long.Parse(number) >= uint.MinValue) { Console.WriteLine("* uint"); }
            if (long.Parse(number) <= long.MaxValue && long.Parse(number) >= long.MinValue) { Console.WriteLine("* long"); }
        }
    }
}
