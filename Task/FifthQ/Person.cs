using System;
using System.Collections.Generic;
using System.Text;

namespace FifthQ
{
    class Person
    {
        private string name;
        private string dob;

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
    }
}
