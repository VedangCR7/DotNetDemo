using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class CurrentAccount : BankAccount
    {
        private double balance;
        public CurrentAccount(double bal)
        {
            this.balance = bal;

        }
        public override void Deposite(double amount)
        {
            balance += amount;
            Console.WriteLine("Updated balance" + balance);
        }

        public override void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Amount Withdrawn {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
}
