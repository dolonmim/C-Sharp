using System;
using System.Collections.Generic;

namespace GenericCollectionsQ
{
    //Generic collections - type safe
    //list<>
    //queue<>
    //stack<>
    //sortedlist<k, v>
    //dictionary<k, v>
    //hashset
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();

            list1.Add(111);
            list1.Add(1);

            List<string> list2 = new List<string>();
            list2.Add("HELLO");
            list2.Add("HELLO there");
            Console.WriteLine("List 1 count: " + list1.Count);
            Console.WriteLine("List 2 count: " + list2.Count);
            Console.WriteLine("List 2 capacity: " + list2.Capacity);

            foreach (var i in list1)
            {
                Console.WriteLine(i);
            }

            foreach (var i in list2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}