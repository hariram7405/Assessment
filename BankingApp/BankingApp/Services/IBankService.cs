using System.Collections.Generic;
using BankingApp.Models;

namespace BankingApp.Services
{
    public interface IBankService
    {
        void DisplayAll(List<UserAccount> users);
        void DisplayTop5(List<UserAccount> users);
        void SearchUser(List<UserAccount> users, string uname);
        void CalculateFD(double amt, double rate, int years);
    }
}
