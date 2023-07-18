using System;
using System.Collections.Generic;
using System.Text;

namespace SixthQ
{
    class Customer : Person
    {
        
        private Account acc;

        public Customer(string name, Account acc) : base(name)
        {
            
            this.acc = acc;
        }

        public void performDeposit(double amount)
        {
            acc.deposit(amount);
        }
        public void performWithdraw(double amount)
        {
            acc.withdraw(amount);
        }

        public void checkauditstatus()
        {
            acc.status();
        }
        public void details()
        {
            Console.WriteLine("Name: " + base.name);
            acc.displayAcc();
        }
    }
}
