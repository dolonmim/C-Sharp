using System;
using System.Collections;

namespace NineQ2
{
    //COLLECTIONS
    //3; non generic, generic, concurrent

    //non generic - arraylist, queue, stack, hashtable
    //generic - list, queue, stack, sortedlist, dictionary

    //non generic - arraylist
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList aList = new ArrayList();

            aList.Add(8);
            aList.Add("OOP2 Q");
            aList.Add(55.5);

            ArrayList bList = new ArrayList() { 100, "Hello" };

            aList.AddRange(bList);

            int a = (int)aList[0];
            string b = (string)aList[1];
            Console.WriteLine("A: " + a);

            aList.Insert(1, "Q OOP2");

            Console.WriteLine("Count: " + aList.Count);
            Console.WriteLine("Capacity: " + aList.Capacity);

            aList.RemoveAt(0);
            aList.Remove(55.5);

            Console.WriteLine("Check for an element: " + aList.Contains(55.5));

            foreach (var i in aList)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}