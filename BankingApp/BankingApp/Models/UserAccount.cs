using System;

namespace BankingApp.Models
{
    public class UserAccount : Users, IServicable
    {
        public UserAccount(int id, string name, string email)
            : base(id, name, email) { }

        public void Deposit(int amt)
        {
            if (amt < 0)
            {
                Console.WriteLine("Amount Cannot be Negative\n");
                return;
            }

            Amount += amt;
            string message = $"{amt} Rupees Deposited Successfully";
            transaction.Add(message);
            Console.WriteLine($"Dear {Name}: {message}");
            Console.WriteLine($"Current Balance: {Amount}\n");
        }

        public void Withdraw(int amt)
        {
            if (amt < 0)
            {
                Console.WriteLine("Amount Cannot be Negative\n");
                return;
            }

            if (Amount < amt)
            {
                Console.WriteLine("Insufficient balance\n");
                return;
            }

            Amount -= amt;
            string message = $"{amt} Rupees Withdrawn Successfully";
            transaction.Add(message);
            Console.WriteLine($"Dear {Name}: {message}");
            Console.WriteLine($"Current Balance: {Amount}\n");
        }
    }
}
