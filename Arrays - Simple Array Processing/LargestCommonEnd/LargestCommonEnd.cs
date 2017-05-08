using System;

namespace LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            var arrayOne = Console.ReadLine().Split(' ');
            var arrayTwo = Console.ReadLine().Split(' ');
            int counter = 0;
            int shorterLenght = Math.Min(arrayOne.Length, arrayTwo.Length);
            bool hasMatch = false;
            bool biggerLenght = arrayOne.Length >= arrayTwo.Length; 

            for (int i = 0; i < shorterLenght; i++)
            {
                if (arrayOne[i].Equals(arrayTwo[i]))
                {
                    counter++;
                    hasMatch = true;
                }
            }

            if (hasMatch == false)
            {
                for (int i = 0; i < shorterLenght; i++)
                {
                    if (biggerLenght)
                    {
                        if (arrayOne[arrayOne.Length - 1 - i].Equals(arrayTwo[arrayTwo.Length - 1 - i]))
                        {
                            counter++;
                        }
                    }
                    else
                    {
                        if (arrayTwo[arrayTwo.Length - 1 - i].Equals(arrayOne[arrayOne.Length - 1 - i]))
                        {
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
