using System;
using System.Collections.Generic;
using System.Text;

namespace SixthQ
{
    interface IAccountOperations
    {
        public void deposit(double amount);
        public void withdraw(double amount);
        public void displayAcc();
    }
}
