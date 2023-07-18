using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_code
{
    class Customer
    {
        public string name;
        private Account acc;
        public Customer(string name,Account acc)
        {
        this.acc=acc;
            this.name = name;
         }
        public void details()
        {
            Console.WriteLine("Name:" + name);
            acc.displayAcc();
        }
    }
}
