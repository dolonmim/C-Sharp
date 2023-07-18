using System;

namespace Interface_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("20-1",1000);
            Customer c1 = new Customer("John",a1);
            c1.details();
            Console.ReadKey();
        }
    }
}
