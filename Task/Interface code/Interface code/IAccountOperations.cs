using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_code
{
    interface IAccountOperations
    {
        //function prototype
        public void deposit(double amount);
        public void withdraw(double amount);
        public void displayAcc();
    }
}
