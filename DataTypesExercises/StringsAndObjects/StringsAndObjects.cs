using System;


namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object concatenated = hello + " " + world;
            string output = (string)concatenated;
            Console.WriteLine(output);
        }
    }
}
