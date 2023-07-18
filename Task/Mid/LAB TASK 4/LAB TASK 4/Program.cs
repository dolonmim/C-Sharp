using System;

namespace LAB_TASK_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.setAccount_id(201);
            a1.setAmount(25000.00);
            a1.setAccType("Emp");
            

            Account a2 = new Account();
            a2.setAccount_id(301);
            a2.setAmount(50000.00);
            a2.setAccType("Cus");

            Employee e1 = new Employee();
            e1.setName("Cinderella");
            e1.setDob("25-07-2000");
            e1.setAcc(a1);
            
            

            Console.WriteLine("Name: " + e1.getName());
            Console.WriteLine("DOB: " + e1.getDob());
            e1.getAcc();
            

            Employee e2 = new Employee("Moana", "12-10-19", a2);
            Console.WriteLine("Name: " + e2.getName());
            Console.WriteLine("DOB: " + e2.getDob());
            e2.getAcc();

            Customer c1 = new Customer();
            c1.setName("Snow White");
            c1.setDob("12-12-12");
            c1.setAcc(a1);

            Console.WriteLine("Name: " + c1.getName());
            Console.WriteLine("DOB: " + c1.getDob());
            c1.getAcc();

            Customer c2 = new Customer("Jasmine","21-04-09",a2);

            Console.WriteLine("Name: " + c2.getName());
            Console.WriteLine("DOB: " + c2.getDob());
            c2.getAcc();

            Console.ReadKey();

        }
       
    }
    
}
