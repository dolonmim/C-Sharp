using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_TASK_4
{
    class Employee : Person
    {
        private Account acc;

        public Employee()
        {
            Console.WriteLine("Employee Empty Constructor");
        }
        public Employee(string name, string dob, Account acc):base(name,dob)
        {
            Console.WriteLine("Employee Parameterized Constructor");
            
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
            Console.WriteLine("Employee Account: " + acc);
        }
    }
}
