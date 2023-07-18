using System;
using System.Collections.Generic;
using System.Text;

namespace FifthQ
{
    abstract class Person
    {
        protected string name;
        protected string dob;

        public Person()
        {
            Console.WriteLine("Empty Person");
        }

        public Person(string name, string dob)
        {
            Console.WriteLine("Parameterized Person");
            this.name = name;
            this.dob = dob;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setDob(string dob)
        {
            this.dob = dob;
        }

        public string getName()
        {
            return name;
        }

        public string getDob()
        {
            return dob;
        }

        /*public virtual void showDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("DOB: " + dob);
        }*/
        public abstract void showDetails();
    }
}
