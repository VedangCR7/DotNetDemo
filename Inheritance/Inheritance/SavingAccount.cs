using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SavingAccount : BankAccount
    {
        private double balance;
        public SavingAccount(double bal) {
            this.balance = bal;
        }


        public override void Deposite(double amount)
        {
            balance += amount;
            Console.WriteLine(balance); 
        }

        public override void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance-= amount;
                Console.WriteLine($"Savings Account: Withdrawn {amount}. Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
}
