using System;
using System.Collections;

namespace TenQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st1 = new Stack();

            st1.Push(5);
            st1.Push("Hello");
            st1.Push(65.5);
            st1.Pop();
            st1.Pop();
            st1.Push(99.99);
            st1.Push("bye");
            st1.Push(75);
            st1.Pop();

            Console.WriteLine(st1.Count);
            Console.WriteLine(st1.Peek());

            Console.WriteLine(st1.Contains(75));

            //print korar jonno
          
            foreach (var i in st1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}