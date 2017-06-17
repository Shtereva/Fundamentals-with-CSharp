using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Andrey_and_billiard
{
    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> ShopList { get; set; }

        public decimal Bill { get; set; }

        public static Customer Read(string name)
        {
            return new Customer
            {
                Name = name,
                ShopList = new Dictionary<string, int>(),
                Bill = 0
            };
        }
    }

    class AndreyAndbilliard
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var priceList = new Dictionary<string, decimal>();
            AddPriceList(input, priceList);

            input = Console.ReadLine();
            var students = new List<Customer>();
            int count = 0;

            while (input != "end of clients")
            {
                var line = input.Split("-,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string name = line[0];
                string product = line[1];
                int quantity = int.Parse(line[2]);

                if (!priceList.ContainsKey(product))
                {
                    input = Console.ReadLine();
                    continue;
                }

                var person = Customer.Read(name);

                person.ShopList[product] = quantity;
                person.Bill = quantity * priceList[product];

                AddStudents(priceList, students, name, product, quantity, person);

                input = Console.ReadLine();
            }

            PrintStudents(students);
        }

        private static void PrintStudents(List<Customer> students)
        {
            foreach (var student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                student.ShopList
                    .ToList()
                    .ForEach(x => Console.WriteLine($"-- {x.Key} - {x.Value}"));
                Console.WriteLine($"Bill: {student.Bill:f2}");
            }
            var total = students.Select(x => x.Bill).ToList();

            Console.WriteLine($"Total bill: {total.Sum():f2}");
        }

        private static void AddStudents(Dictionary<string, decimal> priceList, List<Customer> students, string name, string product, int quantity, Customer person)
        {
            if (!students.Any(x => x.Name == name))
            {
                students.Add(person);
            }

            else
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Name == name)
                    {
                        if (!students[i].ShopList.ContainsKey(product))
                        {
                            students[i].ShopList[product] = 0;
                        }

                        students[i].ShopList[product] += quantity;
                        students[i].Bill += quantity * priceList[product];
                        break;
                    }
                }
            }
        }

        private static void AddPriceList(string input, Dictionary<string, decimal> priceList)
        {
            for (int i = 0; i < int.Parse(input); i++)
            {
                var line = Console.ReadLine().Split("-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string product = line[0];
                decimal price = decimal.Parse(line[1]);

                priceList[product] = price;
            }
        }
    }
}
