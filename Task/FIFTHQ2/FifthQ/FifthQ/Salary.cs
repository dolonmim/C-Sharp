using System;
using System.Collections.Generic;
using System.Text;

namespace FifthQ
{
    class Salary
    {
        private string category;
        private double salAmount;

        public void setCate(string category)
        {
            this.category = category;
        }

        public void setSalAmount(double salAmount)
        {
            this.salAmount = salAmount;
        }

        public void display()
        {
            Console.WriteLine("Salary Category: " + category);
            Console.WriteLine("Salary Amount: " + salAmount);
        }
    }
}
