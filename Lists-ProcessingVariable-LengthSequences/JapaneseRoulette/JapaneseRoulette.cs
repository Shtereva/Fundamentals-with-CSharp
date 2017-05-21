using System;
using System.Collections.Generic;
using System.Linq;

namespace JapaneseRoulette
{
    class JapaneseRoulette
    {
        static void Main()
        {
            var cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var playersParams = Console.ReadLine().Split(' ');
            int bulletPossition = 0;
            bulletPossition = FindBulletPossition(cylinder, bulletPossition); 
            bool deadPlayer = false;
            int currentPlayer = 0;


            for (int i = 0; i < playersParams.Length; i++)
            {
                var array = playersParams[i].Split(',');
                int strenght = int.Parse(array[0]);
                string direction = array[1];
                SpiningGunToy(cylinder, ref bulletPossition, strenght, direction);

                if (bulletPossition == 2)
                {
                    deadPlayer = true;
                    currentPlayer = i;
                    break;
                }

                //bulletPossition = (bulletPossition + 1) % cylinder.Count;
                bulletPossition++;
                if (bulletPossition > cylinder.Count - 1)
                {
                    bulletPossition = 0;
                }
            }

            Console.WriteLine(deadPlayer ? $"Game over! Player {currentPlayer} is dead." : "Everybody got lucky!");
        }

        private static int FindBulletPossition(List<int> cylinder, int bulletPossition)
        {
            for (int j = 0; j < cylinder.Count; j++)
            {
                if (cylinder[j] == 1)
                {
                    bulletPossition = j;
                    break;
                }
            }

            return bulletPossition;
        }

        private static void SpiningGunToy(List<int> cylinder, ref int bulletPossition, int strenght, string direction)
        {
            if (direction == "Right")
            {
                //bulletPossition = (bulletPossition + strenght) % cylinder.Count;
                while (strenght > 0)
                {
                    bulletPossition++;
                    strenght--;
                    if (bulletPossition > cylinder.Count - 1)
                    {
                        bulletPossition = 0;
                    }
                }
            }

            else
            {
                //bulletPossition = Math.Abs(bulletPossition - strenght) % cylinder.Count;
                while (strenght > 0)
                {
                    bulletPossition--;
                    strenght--;
                    if (bulletPossition < 0)
                    {
                        bulletPossition = cylinder.Count - 1;
                    }

                }
            }

        }
    }
}
