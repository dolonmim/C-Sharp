using System;

namespace LabTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name:Dolon Akter Mim");
            Console.WriteLine("ID:20-42511-1");

            Console.WriteLine("Implicit:");
            char b = 'a';
            int a = 5;
            Console.WriteLine(a);

            Console.WriteLine("Explicit:");
            double c = 20.5;
            int d = (int)c;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}