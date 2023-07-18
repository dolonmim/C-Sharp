using System;

namespace SixthQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("A-01", 1000);

            Customer c1 = new Customer("John", a1);

            c1.performDeposit(-500);
            c1.details();

            c1.performWithdraw(-10);
            c1.details();
            c1.checkauditstatus();

            Console.ReadKey();
        }
    }
}
