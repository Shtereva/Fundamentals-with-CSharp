using System;


namespace DoublePalindromes
{
    class DoublePalindromes
    {
        static void Main()
        {
            long number = 0;
            //string palindromeBinary = Convert.ToString(number, 2);
            int counter = 0;

            while (true)
            {
                string palindromeBinary = Convert.ToString(number, 2);
                string palindrome = Convert.ToString(number);
                string compared = string.Empty;
                string comparedBinary = string.Empty;
                for (int i = palindrome.Length - 1; i >= 0; i--)
                {
                    compared += palindrome[i];
                }

                for (int i = palindromeBinary.Length - 1; i >= 0; i--)
                {
                    comparedBinary += palindromeBinary[i];
                }

                if (compared == palindrome && comparedBinary == palindromeBinary)
                {
                    Console.Write($"{number} ");
                    counter++;
                }
                number++;
                if (counter == 129)
                {
                    break;
                }
            }
        }
    }
}
