using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Programming_Language.Day_02
{
    internal class MultiDimensionArray
    {

        internal void PrintArrayJagged(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        void PrintArray2D(int[,]arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for(int i =0;i<rows;i++)
            {
                for(int j = 0;j<cols;j++)
                {
                    Console.Write(arr[i,j] +" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        internal void MultiDArray()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3];
            arr[1] = new int[3];
            arr[2] = new int[3];

            int[,] brr = new int[2, 3];


            PrintArrayJagged(arr);

            PrintArray2D(brr);

        }
    }
}
