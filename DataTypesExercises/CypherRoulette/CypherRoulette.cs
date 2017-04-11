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
            string text = null;
            string cypher = null;
            string currentText = null;
            string afterSpinText = null;
            int countSpins = 0;
            for (int i = 0; i < number; i++)
            {
                string randomText = Console.ReadLine();
                if (currentText == "spin" && countSpins % 2 != 0)
                {
                    afterSpinText = randomText;
                    cypher = afterSpinText + text;
                    if (randomText != currentText) { currentText = randomText; continue; }
                }
                if (randomText == currentText)
                {
                    if (randomText == "spin") { number++; countSpins++; }
                    text = string.Empty;
                    currentText = randomText;
                    cypher = string.Empty;
                    afterSpinText = string.Empty;
                    continue;
                }
                currentText = randomText;
                if (randomText == "spin")
                {
                    number++;
                    countSpins++;
                }
                else
                {
                    text += randomText;
                    cypher = afterSpinText + text;
                }
            }
            Console.WriteLine(cypher);
        }
    }
}
