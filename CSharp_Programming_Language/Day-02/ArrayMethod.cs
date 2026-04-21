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
            int[] arr = new int[] { 1, 2, 3, 4, 6,7,8,9,10};
            int[] brr = { 1, 2, 3, 9, 8 };

            PrintArray(brr);
            Array.Sort(brr);
            PrintArray(brr);

            Array.Reverse(brr);
            PrintArray(brr);
            ReverseArray(arr);

            PrintArray(arr);

            Array.Clear(arr);
            PrintArray(arr);

            Console.WriteLine(Array.IndexOf(arr, 10));

            int[] crr = new int[10];

            //Array.Copy(arr, crr, arr.Length-1);

            Array.Copy(arr, 0, crr, 0, 3);
            // in copy --->   sourse , sourse index, destination, dist index, length;
            Array.Copy(arr, arr.Length - 4, crr, 3, 4);

            Array.Clear(arr, 4, 3);

            PrintArray(arr);

            Console.WriteLine(arr.Rank);


            void Modify_passby_Val(int[] arr)
            {
                arr = new int[] { 9, 9, 9 };
            }

            int[] a = { 1, 2, 3 };
            Modify_passby_Val(a);
            Console.WriteLine(a[0]);


            void Modify_passby_ref(ref int[] arr)
            {
                arr = new int[] { 9, 9, 9 };
            }

            int[] b= { 1, 2, 3 };
            Modify_passby_ref(ref b);
            Console.WriteLine(b[0]);
        }
    }
}
