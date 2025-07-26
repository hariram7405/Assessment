using System;
using System.Collections.Generic;
using BankingApp.Models;
using BankingApp.Services;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserAccount> users = new List<UserAccount>()
            {
                new UserAccount(1001, "Lokesh", "loki@gmail.com"),
                new UserAccount(1002, "Ram", "ram@gmail.com"),
                new UserAccount(1003, "Priya", "priya@gmail.com"),
                new UserAccount(1004, "Praveen", "praveen@gmail.com"),
                new UserAccount(1005, "Krishna", "krishna@gmail.com"),
                new UserAccount(1006, "Rajeshxx", "rajeshxx@gmail.com")
            };

            ChildAccount c1 = new ChildAccount(2001, "Yuvan", "yuvii@gmail.com", "Shivaperumal", "8967898787");
            c1.Deposit(87);
            c1.Display();

            users[0].Deposit(1000);
            users[1].Deposit(8000);
            users[2].Deposit(8999);
            users[3].Deposit(999);
            users[4].Deposit(7999);

            users[1].Withdraw(1000);
            users[3].Withdraw(6000);

            users[0].ShowTransaction();

            IBankService bankService = new BankService();
            Console.WriteLine("Displaying All Bank Users:");
            bankService.DisplayAll(users);
            Console.WriteLine();

            Console.WriteLine("Displaying Top 5 Bank Users:");
            bankService.DisplayTop5(users);
            Console.WriteLine();

            Console.WriteLine("Searching for Users:");
            bankService.SearchUser(users, "Ram");
            bankService.SearchUser(users, "Tharun");
            Console.WriteLine();

            Console.WriteLine("Calculating Fixed Deposit");
            bankService.CalculateFD(100000, 7.5 ,3);
            Console.WriteLine();
        }
    }
}
