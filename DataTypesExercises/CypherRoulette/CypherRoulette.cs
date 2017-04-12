using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CypherRoulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = string.Empty;
            string cypher = string.Empty;
            string currentText = string.Empty;
            string afterSpinText = string.Empty;
            int countSpins = 0;
            for (int i = 0; i < number; i++)
            {
                string randomText = Console.ReadLine();
                if (randomText == currentText)
                {
                    if (randomText == "spin") { number++; }
                    text = string.Empty; cypher = string.Empty; afterSpinText = string.Empty; countSpins = 0; currentText = string.Empty;
                    continue;
                }
                if (randomText != "spin")
                {
                        text += randomText;
                        cypher = text;
                        currentText = randomText;
                }
                else
                {
                    afterSpinText = Console.ReadLine();
                    if (countSpins == 0)
                        {
                            cypher = afterSpinText + text;
                            text = cypher;
                        }
                        else
                        {
                            cypher = text + afterSpinText;
                            text = cypher;
                        }
                        countSpins++;
                        currentText = afterSpinText;
                }
            }
            Console.WriteLine(cypher);
        }
    }
}
