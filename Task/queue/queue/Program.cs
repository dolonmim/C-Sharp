using System;
using System.Collections;

namespace TenQ1
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue q1 = new Queue();

            q1.Enqueue(55);
            q1.Enqueue(99.99);
            q1.Enqueue("hi there");

            q1.Dequeue();

            Console.WriteLine("Count: " + q1.Count);

            Console.WriteLine(q1.Contains("hi there"));

            foreach (var i in q1)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}