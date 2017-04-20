using System;


namespace StringEncryption
{
    class StringEncryption
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string outputResult = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                string result = string.Empty;
                string encryption = Encrypt(letter);
                outputResult += encryption;
            }
            Console.WriteLine(outputResult);
        }

        static string Encrypt(char letter)
        {
            int lastDigit = GetLastDigit(letter);

            int firstDigit = GetFirstDigit(letter);

            string result = firstDigit.ToString() + lastDigit.ToString();

            int sumWithLastDigit = letter + lastDigit;

            result = (char)(sumWithLastDigit) + result;

            int sumWithFirstDigit = letter - firstDigit;

            result += (char)(sumWithFirstDigit);

            return result;
        }

         static int GetFirstDigit(int letter)
        {
            int result = letter;
            while (result >= 10)
            {
                result /= 10;
            }

            return result;
        }

        static int GetLastDigit(int letter)
        {
            return letter % 10;
        }
    }
}
