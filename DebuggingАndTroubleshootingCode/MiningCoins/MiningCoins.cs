using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningCoins
{
    class MiningCoins
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;
            float totalValue = 0f;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int decryptedChar = 0;

                int digit1 = number / 100;
                int digit2 = (number / 10) % 10;
                int digit3 = number % 10;

                if (i % 2 != 0)
                {
                    decryptedChar = ((digit1 * 10) + digit3) - digit2;
                }

                else
                {
                    decryptedChar = ((digit1 * 10) + digit3) + digit2;
                }

                if ((decryptedChar >= 65 && decryptedChar <= 90) || (decryptedChar >= 97 && decryptedChar <= 122))
                {
                    decrypted += (char)decryptedChar;
                }

                totalValue += ((digit1 + digit2 + digit3) / (float)n);
            }


            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}
