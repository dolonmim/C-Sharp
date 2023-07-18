using System;

namespace NingthQ1
{
    //methods as parameter

    public delegate void SampleCalc(int a, int b);

    class BasicMaths
    {
        public void add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition: " + result);
        }
        public void sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction: " + result);
        }

        public void square(int a)
        {
            int result = a * a;
            Console.WriteLine("Square: " + result);
        }
    }
    class Program
    {
        static void SampleFunc(SampleCalc s1, int a, int b)
        {
            s1(a, b);
        }
        static void Main(string[] args)
        {
            BasicMaths bm1 = new BasicMaths();

            //SampleCalc sc1 = bm1.add;
            //sc1 = sc1 + bm1.sub;
            //sc1 = sc1 + bm1.square;
            // sc1(15, 5);

            SampleFunc(bm1.add, 15, 5);
            SampleFunc(bm1.sub, 25, 5);
            Console.ReadKey();
        }
    }
}