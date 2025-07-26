using System;
using System.Collections.Generic;
using BankingApp.Models;

namespace BankingApp.Services
{
    public class BankService : IBankService
    {
        public void DisplayAll(List<UserAccount> users)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"{"Name",-25} {"Account Number",-20} {"Email",-30} {"Balance",10}");
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            foreach (UserAccount x in users)
            {
                Console.WriteLine($"{x.Name,-25} {x.AccountNumber,-20} {x.Email,-30} {x.Amount,10}");
            }
        }

        public void SearchUser(List<UserAccount> users, string uname)
        {
            bool found = false;

            foreach (UserAccount x in users)
            {
                if (x.Name.Equals(uname, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"User already exists: {uname}\n");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"User does not exist: {uname}\n");
            }
        }

        public void DisplayTop5(List<UserAccount> users)
        {
            for (int i = 0; i < users.Count - 1; i++)
            {
                for (int j = 0; j < users.Count - i - 1; j++)
                {
                    if (users[j].Amount < users[j + 1].Amount)
                    {
                        var temp = users[j];
                        users[j] = users[j + 1];
                        users[j + 1] = temp;
                    }
                }
            }

            int count = Math.Min(5, users.Count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Name: {users[i].Name} | Balance: {users[i].Amount}");
            }
        }

        public void CalculateFD(double amt,double  rate, int years)
        {
           double maturityAmount = amt * (double)Math.Pow((1 + rate / 100), years);
            Console.WriteLine($"Amount: {amt}");
            Console.WriteLine($"Rate: {rate}");
            Console.WriteLine($"Years: {years}");
            Console.WriteLine("FD Maturity Amount: " + maturityAmount);
            Console.WriteLine();
        }
    }
}
