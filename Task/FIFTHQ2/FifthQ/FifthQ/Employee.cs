using System;
using System.Collections.Generic;
using System.Text;

namespace FifthQ
{
    class Employee : Person //inheritance - is a// general/normal employees - working under admins.
    {
        private int empId;
        private Salary sal; // association
  
        public void setempId(int empId)
        {
            this.empId = empId; 
        }
        public int getempId()
        {
            return empId;
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
            Console.WriteLine("Admin ID: " + empId);
            sal.display();
        }
    }
}
