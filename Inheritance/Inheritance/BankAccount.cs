using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract public class BankAccount
    {
        public abstract void Deposite(double amount);
        public abstract void Withdraw(double amount);
    }
}
