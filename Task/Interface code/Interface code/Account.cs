using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_code
{
    class Account : IAccountOperations
    {
        private string accID;
        private double balance;

        public Account(string accID, double balance)
        {
            this.accID = accID;
            this.balance = balance;
        }
            

        public void deposit(double amount)
        {
            if (amount>0)
            {
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount :" );
            }
        }
        public void withdraw(double amount)
        {
            balance -= amount;
        }
        public void displayAcc()
        {
            Console.WriteLine("Account ID:" + accID);
            Console.WriteLine("Balance:" + balance);
        }
    }
}
