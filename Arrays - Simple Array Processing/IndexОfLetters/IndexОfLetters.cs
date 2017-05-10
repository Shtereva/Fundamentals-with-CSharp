using System;


namespace IndexОfLetters
{
    class IndexОfLetters
    {
        static void Main()
        {
            var array = new char[26];
            int index = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                array[index] = i;
                index++;
            }

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (input[i].Equals(array[j]))
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }
        }
    }
}
