using System;
using System.Collections.Generic;

namespace BankingApp.Models
{
    public abstract class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Amount;
        public int AccountNumber;

        private static int NextAccountNumber = 12345678;
        protected List<string> transaction = new List<string>();

        public Users(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            Amount = 0;
            AccountNumber = NextAccountNumber++;

            string message = $"{Name}: Account Created Successfully!";
            transaction.Add(message);
            Console.WriteLine(message);
            Console.WriteLine();
        }

        public void Display()
        {
            Console.WriteLine($"Account Holder Name: {Name}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Balance: {Amount}");
            Console.WriteLine();
        }

        public void ShowTransaction()
        {
            if (transaction.Count == 0)
            {
                Console.WriteLine("No Transaction Available");
            }
            else
            {
                Console.WriteLine($"Displaying {Name}'s Transactions:");
                foreach (string x in transaction)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine();
            }
        }
    }
}
