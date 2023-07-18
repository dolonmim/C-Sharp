using System;

namespace lab_2
{
    class Program : DolonAkterMim
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("** Access Modifier and other Constructors**");
            DolonAkterMim t1 = new DolonAkterMim();
            Program p1 = new Program();
            t1.name="Dolon Akter Mim";
            t1.id = 42511;
            p1.semester = "Sixth";
            t1.program = "OOP2";
            t1.university = "AIUB";
            t1.show();
            p1.setCgpa(3.71F);
            Console.WriteLine(t1.getCgpa());

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("** Access Modifier and other Constructors**");
            DolonAkterMim t2 = new DolonAkterMim("XYZ", 101, 3.5F, "Second", "OOP2", "BRAC");
            t2.show();

            

            
            Console.ReadKey();
        } 
    }
}
