using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Programming_Language.Day_02
{
    internal class ArrayMethod
    {

        internal void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length-1;

            while(start<end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            PrintArray(arr);
        }

        internal void PrintArray(int[] arr)
        {
            for(int i =0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
        internal void ArrayOperation()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            int[] brr = { 1, 2, 3, 9, 8 };

            PrintArray(brr);
            Array.Sort(brr);
            PrintArray(brr);

            Array.Reverse(brr);
            PrintArray(brr);
            ReverseArray(arr);

            PrintArray(arr);

        }
    }
}
