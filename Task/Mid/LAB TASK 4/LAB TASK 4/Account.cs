using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_TASK_4
{
    class Account 
    {
        private int account_id;
        private double amount;
        private string accType;

        public Account()
        {
            Console.WriteLine("Person Empty Constructor");
        }

        public Account(int account_id, double amount, string accType)
        {
            Console.WriteLine("Account Parameterized Constructor");
            this.account_id = account_id;
            this.amount = amount;
            this.accType = accType;
         }
        
        public void setAccount_id(int account_id)
        {
            this.account_id = account_id;
        }
        public void setAmount(double amount)
        {
            this.amount = amount;
        }
        public void setAccType(string accType)
        {
            this.accType = accType;
        }
        public int getAccount_id()
        {
            return account_id;
        }
        public double getAmount()
        {
            return amount;
        }
        public string getAccType()
        {
            return accType;
        }


        public void display()
        {
            Console.WriteLine("Account Id: "+ account_id);
            Console.WriteLine("Account Amount: "+ amount);
            Console.WriteLine("Account Type: "+ accType);
        }

    }
}
