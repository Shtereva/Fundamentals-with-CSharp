using System;
using System.Collections.Generic;
using System.Linq;
class OrderedBankingSystem
{
    static void Main()
    {
        string input = Console.ReadLine();
        var bankAccounts = new Dictionary<string, Dictionary<string, decimal>>();
        //            bank              account    balance

        while (input != "end")
        {
            var line = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            string bank = line[0];
            string account = line[1];
            decimal balance = decimal.Parse(line[2]);
            AddingAccountToBank(bankAccounts, bank, account, balance);

            input = Console.ReadLine();
        }

        bankAccounts
            .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
            .ThenByDescending(bank => bank.Value.Max(account => account.Value))
            .ToList()
            .ForEach(bank => bank.Value
            .OrderByDescending(account => account.Value)
            .ToList()
            .ForEach(account => Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})")));
    }

    private static void AddingAccountToBank(Dictionary<string, Dictionary<string, decimal>> bankAccounts, string bank, string account, decimal balance)
    {
        if (!bankAccounts.ContainsKey(bank))
        {
            bankAccounts[bank] = new Dictionary<string, decimal>();
        }

        if (bankAccounts[bank].ContainsKey(account))
        {
            bankAccounts[bank][account] = balance + bankAccounts[bank][account];
        }

        else
        {
            bankAccounts[bank][account] = balance;
        }

    }
}
