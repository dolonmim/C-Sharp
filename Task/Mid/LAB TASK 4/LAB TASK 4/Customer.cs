using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_TASK_4
{
    class Customer:Person
    {
        private Account acc;
        

        public Customer()
        {
            Console.WriteLine("Customer Empty Constructor");
        }
        public Customer(string name, string dob, Account acc):base(name,dob)
        {
            Console.WriteLine("Customer Parameterized Constructor");
            this.acc = acc;
        }
        public void setAcc(Account acc)
        {
            this.acc = acc;
        }
        public void getAcc()
        {
            acc.display();
        }
        public void display()
        {
            Console.WriteLine("Customer Account: " + acc);
            

        }
      }
}
