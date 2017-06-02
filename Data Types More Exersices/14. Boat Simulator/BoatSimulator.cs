using System;
class BoatSimulator
{
    static void Main()
    {
        char firstBoat = char.Parse(Console.ReadLine());
        char secondBoat = char.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        bool winner = false;

        int firsTiles = 0;
        int secondTiles = 0;

        for (int i = 1; i <= n; i++)
        {
            string line = Console.ReadLine();
            if (line == "UPGRADE")
            {
                int temp = firstBoat + 3;
                firstBoat = (char)temp;
                temp = secondBoat + 3;
                secondBoat = (char)temp;
                continue;
            }
            CalculateMoves(firstBoat, secondBoat, ref winner, ref firsTiles, ref secondTiles, i, line);
            if (winner == true)
            {
                break;
            }
        }

        if (winner == false)
        {
            if (firsTiles > secondTiles)
            {
                Console.WriteLine(firstBoat);
            }

            else
            {
                Console.WriteLine(secondBoat);
            }
        }
    }

    private static void CalculateMoves(char firstBoat, char secondBoat, ref bool winner, ref int firsTiles, ref int secondTiles, int i, string line)
    {
        if (i % 2 != 0)
        {
            firsTiles += line.Length;
            if (firsTiles >= 50)
            {
                winner = true;
                Console.WriteLine(firstBoat);
                return;
            }
        }

        else
        {
            secondTiles += line.Length;
            if (secondTiles >= 50)
            {
                winner = true;
                Console.WriteLine(secondBoat);
                return;
            }
        }
    }
}
