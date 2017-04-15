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
            bool countSpins = true;
            for (int i = 0; i < number; i++)
            {
                string randomText = Console.ReadLine();
                if (randomText == "spin") { number++; }
                if (randomText == "spin")
                {
                     countSpins = !countSpins;
                }
                    switch (countSpins)
                    {
                        case (true): cypher = text + randomText; text = cypher; break;
                        case (false): cypher = randomText + text; text = cypher; break;
                    }
                if (randomText == currentText)
                {
                    text = string.Empty; cypher = string.Empty;
                    if (currentText == "spin")
                    {
                        countSpins = !countSpins;
                    }
                    currentText = randomText;
                }
                currentText = randomText;
            }
            cypher = cypher.Replace("spin", string.Empty);
            Console.WriteLine(cypher);
        }
    }
}
