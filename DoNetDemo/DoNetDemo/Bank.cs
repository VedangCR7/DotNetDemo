using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNetDemo
{
    internal class Bank
    {
        public class BankDemo
        {
            private decimal balance;
            public BankDemo(decimal initialBalance)
            {
                balance = initialBalance;
            }
            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposit Successful! New Balance: {balance:C}");
                }
                else
                {
                    Console.WriteLine("Deposit amount must be positive.");
                }
            }
            public void Withdraw(decimal amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawal Successful! New Balance: {balance:C}");
                }
                else if (amount > balance)
                {
                    Console.WriteLine("Insufficient balance for withdrawal.");
                }
                else
                {
                    Console.WriteLine("Withdrawal amount must be positive.");
                }
            }
            public void DisplayBalance()
            {
                Console.WriteLine($"Current Balance: {balance:C}");
            }

        }
    }
}