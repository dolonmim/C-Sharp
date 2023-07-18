using System;
using System.Collections.Generic;
using System.Text;

namespace FifthQ
{
    class Customer : Person //inheritance - is a
    {
        private int cusId;
        public void setcusId(int cusId)
        {
            this.cusId = cusId;
        }
        public int getcusId()
        {
            return cusId;
        }

        public override void showDetails()
        {

            Console.WriteLine("Name: " + name);
            Console.WriteLine("DOB: " + dob);
            Console.WriteLine("Admin ID: " + cusId);
           
        }
    }
}
