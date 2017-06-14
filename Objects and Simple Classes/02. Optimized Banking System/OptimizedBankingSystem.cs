using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _02.Optimized_Banking_System
{
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }

        public static BankAccount Read(string input)
        {
            var line = input.Split("| ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            return new BankAccount
            {
                Bank = line[0],
                Name = line[1],
                Balance = decimal.Parse(line[2])
            };
        }
    }      

    class OptimizedBankingSystem
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var accounts = new Dictionary<string, Dictionary<string, decimal>>();

            while (input != "end")
            {
                var line = BankAccount.Read(input);

                if (!accounts.ContainsKey(line.Name))
                {
                    accounts[line.Name] = new Dictionary<string, decimal>();
                }

                    accounts[line.Name][line.Bank] = line.Balance;

                input = Console.ReadLine();
            }

            accounts = accounts
                .OrderByDescending(name => name.Value.Max(bank => bank.Value))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var name in accounts)
            {
                foreach (var bank in name.Value.OrderBy(x => x.Key.Length))
                {
                    Console.WriteLine($"{name.Key} -> {bank.Value} ({bank.Key})");
                }
            }
        }
    }
}
