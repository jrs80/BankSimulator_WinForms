using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public interface IBankAccount
    {
        double Deposit(double amt);
        double Withdraw(double amt);
        double GetBalance();
        bool OrderChecks();
    }
}
