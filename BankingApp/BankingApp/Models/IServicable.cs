using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.Models
{
public interface IServicable
    {
        public void Deposit(int amt );
        public void Withdraw(int amt);
    }
}
