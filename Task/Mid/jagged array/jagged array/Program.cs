using System;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {

            // [] -> array notation
            // type []arr, type[] arr
            //[,] - > 2d array, [,,] -> 3d array
            // [row][column] -> jagged array -> array(s) inside array

            int[][] arr1 = new int[2][];

            arr1[0] = new int[] { 1, 2, 3 };
            arr1[1] = new int[] { 5, 6 };


            for (int i = 0; i < arr1.Length; i++)
            //i, j -> index
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.WriteLine("arr1[" + i + "] [" + j + "]: " + arr1[i][j]);
                }
            }

            foreach (int[] i in arr1)
            {
                foreach (int j in i)
                {
                    Console.WriteLine(j);
                }

            }

            Console.ReadKey();
        }
    }
}
