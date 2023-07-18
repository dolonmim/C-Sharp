using System;

namespace NingthQ1
{

    //basic generic method
    class GenericMethod
    {
        public void Display<T>(T a, T b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericMethod gc1 = new GenericMethod();

            gc1.Display<int>(1, 2);
            gc1.Display<string>("hello ", "there!");

            Console.ReadKey();

        }
    }
}