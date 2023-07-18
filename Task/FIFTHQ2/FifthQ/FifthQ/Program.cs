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
            
            Admin a1 = new Admin("Arthur", "12-Feb-1991", "a-02", s1);
            a1.showDetails();

            Console.ReadKey();
        }
    }
}
