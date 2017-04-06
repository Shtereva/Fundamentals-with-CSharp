using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            var currency1 = Console.ReadLine().ToLower();
            var currency2 = Console.ReadLine().ToLower();
            decimal eur = 1.95583m;
            decimal usd = 1.79549m;
            decimal gbp = 2.53405m;

            if (currency1 == "usd")
            
                if(currency2 == "bgn")
                
                    Console.WriteLine(Math.Round(num * usd, 2));
                
                else if(currency2 == "eur")
                
                    Console.WriteLine(Math.Round((num * usd)/ eur, 2));
                
                else if(currency2 == "gbp")
                
                    Console.WriteLine(Math.Round((num * usd)/ gbp, 2));
                
            

            if(currency1 == "bgn")
            
                if (currency2 == "usd")
                
                    Console.WriteLine(Math.Round(num / usd, 2));
                
                else if (currency2 == "eur")
                
                    Console.WriteLine(Math.Round(num / eur, 2));
                
                else if(currency2 == "gbp")
                
                    Console.WriteLine(Math.Round(num/ gbp, 2));
                
            

            if(currency1 == "gbp")
            
                if(currency2 == "bgn")
                
                    Console.WriteLine(Math.Round(num * gbp, 2));
                
                else if(currency2 == "eur")
                
                    Console.WriteLine(Math.Round((num * gbp)/ eur, 2));
                
                else if(currency2 == "usd")
                
                    Console.WriteLine(Math.Round((num * gbp)/ usd, 2));
                
            

            if(currency1 == "eur")
            
                if(currency2 == "bgn")
                
                    Console.WriteLine(Math.Round(num * eur, 2));
                
                else if(currency2 == "usd")
                
                    Console.WriteLine(Math.Round((num * eur)/ usd, 2));
                
                else if(currency2 == "gbp")
                
                    Console.WriteLine(Math.Round((num * eur)/ gbp, 2));
                
            
            
        }
    }
}
