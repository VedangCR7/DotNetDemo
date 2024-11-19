using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Bank
    {
        public delegate void BalanceEventHandler(string message);
        public event BalanceEventHandler InsufficientBalance;
        public event BalanceEventHandler LowBalance;
        public event BalanceEventHandler ZeroBalance;

       
        private decimal balance;

       public Bank(decimal initialBalance)
        {
            balance = initialBalance;
        }

        
        public void Credit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Credit amount must be positive.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Amount credited: {amount}. New balance: {balance}");
        }

        
        public void Debit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Debit amount must be positive.");
                return;
            }

            if (amount > balance)
            {
                
                InsufficientBalance?.Invoke("Insufficient balance to complete the transaction.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Amount debited: {amount}. New balance: {balance}");

                
                if (balance < 3000)
                {
                    LowBalance?.Invoke("Your balance is low, below 3000.");
                }

                
                if (balance == 0)
                {
                    ZeroBalance?.Invoke("Your balance is zero.");
                }
            }
        }

        
        public decimal GetBalance()
        {
            return balance;
        }

    }
}
