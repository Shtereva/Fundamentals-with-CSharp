using System;


namespace TrickyStrings
{
    class TrickyStrings
    {
        static void Main()
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            var result = string.Empty;
            for (int i = 0; i < numberOfStrings; i++)
            {
                var currentString = Console.ReadLine();
                result += currentString + delimiter;
            }
            int delimeterLenght = result.Length - delimiter.Length;
            result = result.Remove(delimeterLenght, delimiter.Length);
            Console.WriteLine(result);
        }
    }
}
