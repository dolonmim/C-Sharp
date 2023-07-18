using System;

namespace EightQI
{
    class Students
    {
        private string[] ar1 = new string[3]; // 0-ABC, 1-DEF, 2-PQR
                                              //indexer
        public string this[int i]
        {
            get { return ar1[i]; }
            set { ar1[i] = value; }
        }

        //indexer overloading
        public string this[string name]
        {
            get
            {
                foreach (string s1 in ar1)
                {
                    if (s1.ToLower() == name.ToLower())
                    // Abc->abc == abc
                    {
                        return s1.ToUpper();
                    }
                }
                return null;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Students slist = new Students();

            slist[0] = "Abc";
            slist[1] = "DEF";
            slist[2] = "PQR";


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(slist[i]);
            }

            Console.WriteLine(slist["ABC"]);
            Console.ReadKey();
        }
    }
}