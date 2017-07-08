using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            decimal sets = Math.Ceiling((decimal)guests / 6m);
            decimal oneSetPrice = 2m * bananasPrice + 4m * eggsPrice + 0.2m * berriesPrice;
            decimal allPrice = sets * oneSetPrice;


            if (allPrice <= cash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", allPrice);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", (allPrice - cash));
            }
        }
    }
}