using System;

namespace NingthQ1
{
    //basic generic class
    class GenericClass<T>
    {
        public T test;

        public GenericClass()
        {

        }
        public GenericClass(T test)
        {
            this.test = test;
        }
        public void setTest(T test)
        {
            this.test = test;
        }

        public T getTest()
        {
            return test;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gc1 = new GenericClass<string>();
            gc1.setTest("Hello There!");
            Console.WriteLine(gc1.getTest());

            GenericClass<int> gc2 = new GenericClass<int>();
            gc2.setTest(75);
            Console.WriteLine(gc2.getTest());

            GenericClass<double> gc3 = new GenericClass<double>();
            gc3.setTest(75.5);
            Console.WriteLine(gc3.getTest());

            Console.ReadKey();

        }
    }
}