using System;


namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            string text = Console.ReadLine();
            bool convert = Convert.ToBoolean(text);
            if (convert)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
