using System;
using System.Collections.Generic;
using System.Text;

namespace SixthQ
{
    abstract class Person
    {
        protected string name;
        
        public Person(string name)
        {
            this.name = name;
        }
    }
}
