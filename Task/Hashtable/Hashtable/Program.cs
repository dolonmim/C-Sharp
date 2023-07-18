using System;
using System.Collections;
using System.Collections.Generic;

namespace NineQ2
{
    //COLLECTIONS
    //3; non generic, generic, concurrent

    //non generic - arraylist, queue, stack, hashtable
    //generic - list, queue, stack, sortedlist, dictionary

    //non generic - hash table
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht1 = new Hashtable();

            ht1.Add(5, "Five");
            ht1.Add(51, 65);
            ht1.Add("hello", "bye");
            ht1.Add("hello1", 55.559);

            ht1[2] = "oop2 q";

            try
            {
                ht1.Add("hello", 55);
            }
            catch
            {
                Console.WriteLine("Already Exists! Try something new!");
            }

            ht1.Remove("hello");
            //ContainKey, ContainsValue

            foreach (DictionaryEntry i in ht1)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
            Console.ReadKey();
        }
    }
}