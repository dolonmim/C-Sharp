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

    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CGPA { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(5);

            Students s1 = new Students();
            s1.Id = 1;
            s1.Name = "oop2 q";
            s1.CGPA = 3.33;

            List<Students> slist = new List<Students>()
{
new Students{Id=2, Name="oop2 q2", CGPA=3.23}, //0
new Students{Id=3, Name="oop2 q3", CGPA=3.43}, //2
new Students{Id=4, Name="oop2 q4", CGPA=3.53} //3
};
            slist.Insert(1, s1); //1
            slist.Remove(s1);
            slist.RemoveAt(0);

            foreach (Students i in slist)
            {
                Console.WriteLine(i.Id + " " + i.Name + " " + i.CGPA);
            }

            Console.ReadKey();
        }
    }
}