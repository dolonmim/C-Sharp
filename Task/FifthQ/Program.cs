using System;

namespace FifthQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary s1 = new Salary();
            s1.setCate("A");
            s1.setSalAmount(60000.66);

            Salary s2 = new Salary();
            s2.setCate("A");
            s2.setSalAmount(55000.66);
            /*Employee e1 = new Employee();
            Customer c1 = new Customer();*/

            Admin a1 = new Admin();

            a1.setName("William");
            a1.setDob("03-Jan-2001");
            a1.setaId("a-01");
            a1.setSal(s1);


            /*e1.setName("John");
            e1.setDob("08-Jan-2004");
            e1.setempId(8);

            c1.setName("Hopkins");
            c1.setDob("05-Feb-2001");
            c1.setcusId(105);*/

            Console.WriteLine("Name: " + a1.getName());
            Console.WriteLine("ID: " + a1.getaId());
            Console.WriteLine("DOB: " + a1.getDob());
            a1.getSal();

            Admin a2 = new Admin("Arthur", "12-Feb-1991", "a-02", s2);

            Console.WriteLine("Name: " + a2.getName());
            Console.WriteLine("ID: " + a2.getaId());
            Console.WriteLine("DOB: " + a2.getDob());
            a2.getSal();

            /*Console.WriteLine("Name: " + e1.getName());
            Console.WriteLine("ID: " + e1.getempId());
            Console.WriteLine("DOB: " + e1.getDob());

            Console.WriteLine("Name: " + c1.getName());
            Console.WriteLine("ID: " + c1.getcusId());
            Console.WriteLine("DOB: " + c1.getDob());*/

            Console.ReadKey();
        }
    }
}
