using System;

namespace lab_task_3
{
    class Program
    {
        //pass by value
        public static void add(int a)
        {
            a = a + 511;
            Console.WriteLine("Inside pass by value method: " + a);
        }

        //pass by refrence
        public static void mul(ref int a)
        {
            a = a * 511;
            Console.WriteLine("Inside pass by refrence: " + a);
        }

        //out parameter
        public static void multiply(out int a)
        {
            a = 511;
            a = a * 1;
            Console.WriteLine("Inside out parameter: " + a);
        }

        //params
        public static void number(params int[] a )
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        //named parameter
        public static void add(int c,double d)
        {
            Console.WriteLine(c + d);

        }


        static void Main(string[] args)
        {
            int a = 511;
            Console.WriteLine("Before pass by value method: " + a);
            add(a);
            Console.WriteLine("After pass by value method: " + a);

            Console.WriteLine(" ");
            Console.WriteLine("Before pass by reference method: " + a);
            mul(ref a);
            Console.WriteLine("After pass by reference method: " + a);

            Console.WriteLine(" ");
            Console.WriteLine("Before out parameter: " + a);
            multiply(out a);
            Console.WriteLine("After out parameter: " + a);

            Console.WriteLine(" ");
            Console.WriteLine("Params: " );
            number(2, 0, 4, 2, 5, 1, 1, 1);


            int e = 20;
            double f = 35.5;
            Console.WriteLine(" ");
            Console.WriteLine("Named parameter: ");
            add(d:f,c:e);

            Console.WriteLine(" ");
            Console.WriteLine("Jagged Array: ");
            char [][]arr1 =new char[2] [];
            arr1[0] = new char[] { 'a' ,'b','c'};
            arr1[1] = new char[] { 'd','e' };
            Console.WriteLine(arr1[0][0]);
            Console.WriteLine(arr1[0][1]);
            Console.WriteLine(arr1[0][2]);
            Console.WriteLine(arr1[1][0]) ;
            Console.WriteLine(arr1[1][1]) ;

            Console.WriteLine(" ");
            Console.WriteLine("After c is replaced by f and e is replaced by g: ");
            arr1[0][2] = 'f';
            arr1[1][1] = 'g';
            Console.WriteLine(arr1[0][0]);
            Console.WriteLine(arr1[0][1]);
            Console.WriteLine(arr1[0][2]);
            Console.WriteLine(arr1[1][0]);
            Console.WriteLine(arr1[1][1]);



            for (int i=0;i< arr1.Length;i++)
            {
                for(int j=0;j<2;j++)
                {

                }
            }



            Console.ReadKey();
        }
    }
}
