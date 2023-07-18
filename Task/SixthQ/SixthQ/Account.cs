using System;
using System.Collections.Generic;
using System.Text;

namespace SixthQ
{
    class Account : IAccountOperations, IAudit
    {
        private string accID;
        private double balance;

        public Account(string accID, double balance)
        {
            this.accID = accID;
            this.balance = balance;
        }
        public void deposit(double amount)
            // 500,  -100 , 0
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine("Deposit successful!");
            }
            else
            {
                Console.WriteLine("Deposit failed! Invalid Amount!");
            }
        }
        public void withdraw(double amount)
            //500, 1000
        {
            if (amount <=balance && amount > 0)
            {
                balance = balance - amount;
                Console.WriteLine("Withdraw successful!");

            }
            else 
            {
                Console.WriteLine("Withdraw failed! Insufficient balance!");
            }
            
        }
        public void displayAcc()
        {
            Console.WriteLine("Account ID: "+accID);
            Console.WriteLine("Balance : "+balance);
        }

        public void status()
        {
            Console.WriteLine("Audit Complete");
        }
    }
}
