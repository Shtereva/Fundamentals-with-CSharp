using System;


namespace HelloName
{
    class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintHelloName(name);
        }

         static void PrintHelloName(string name)
        {
            Console.WriteLine("Hello, {0}!" , name);
        }
    }
}
