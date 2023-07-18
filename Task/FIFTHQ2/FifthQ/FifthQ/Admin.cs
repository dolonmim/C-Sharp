using System;
using System.Collections.Generic;
using System.Text;

namespace FifthQ
{
    sealed class Admin : Person //inheritance - is a
    {
        
        private string aId;
        private Salary sal; // association

        public Admin()
        {
            Console.WriteLine("Empty Admin");
        }

        //calling base class constructor
        public Admin(string name, string dob, string aId, Salary sal) : base(name, dob)
        {
            Console.WriteLine("Parameterized Admin");
            this.aId = aId;
            this.sal = sal;

        }
        public void setaId(string aId)
        {
            this.aId = aId;
        }
        public string getaId()
        {
            return aId;
        }

        public void setSal(Salary sal)
        {
            this.sal = sal;
        }
        public void getSal()
        {
            sal.display();
            
        }

        public override void showDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("DOB: " + dob);
            Console.WriteLine("Admin ID: " + aId);
            sal.display();
        }
    }
}
