using System;

namespace EightQD
{

    //Delegate - Mulicast
    public delegate void SampleDel(int a, int b);
    class Calculator
    {
        public void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition: " + result);
        }
        public void subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction: " + result);
        }
        public void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Subtraction: " + result);
        }
        public void division(int a, int b)
        {
            double result = a / b;
            Console.WriteLine("Division: " + result);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            SampleDel del = c1.addition;
            //multicast
            del += c1.subtraction;
            del += c1.multiplication;
            del += c1.division;

            del(10, 5);

            Console.ReadKey();
        }
    }
}