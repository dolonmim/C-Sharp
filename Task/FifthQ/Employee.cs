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
        public Salary getSal()
        {
            return sal;

        }
    }
}
