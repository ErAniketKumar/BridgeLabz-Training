using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Programming_Language.Day_03
{
    internal class StringOpr
    {
        internal void StringMethod() {
            string name = "Aniket";
            string name2 = "Aniket";
            StringBuilder name3 = new StringBuilder("Aniket");
            Console.WriteLine(name == name2);
            Console.WriteLine(name.Equals(name2));
            //Console.WriteLine(name == name3);
            Console.WriteLine(name.Equals(name3));

            string a = "hello";
            string b = new string("hello");
            Console.WriteLine(a == b);

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(object.ReferenceEquals(name, name2));

            object aa = new string("test");
            object bb = new string("test");

            Console.WriteLine("here");
            Console.WriteLine(aa == bb);
            Console.WriteLine(aa.Equals(bb));

            StringBuilder sb1 = new StringBuilder("hi");
            StringBuilder sb2 = new StringBuilder("hi");

            Console.WriteLine(sb1 == sb2);
            Console.WriteLine(sb1.Equals(sb2));

            string words = "hi my name is aniket       i'm       from patna bihar";
            Console.WriteLine(words);
            Console.WriteLine(words.Contains("patna"));

            Console.WriteLine(words.IndexOf("is"));
            Console.WriteLine(words.ToUpper());
            Console.WriteLine(words.ToLower());

 

            //string[] words_arr = words.Split(" ");
            string[] words_arr = words.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            int count =  words.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("count: "+count);

            //Console.WriteLine(words_arr)


            for (int i = 0; i < words_arr.Length; i++)
            { 
                Console.Write(words_arr[i]+" ");
            }
            Console.WriteLine();
            string text = string.Join(" ", words_arr);
            Console.WriteLine(text);


            StringBuilder sb = new StringBuilder();

            sb.Append("Hi ");
            sb.Append("Aniket");
            sb.Append("hello");
            sb.AppendLine("world");
            sb.Insert(0, "start ");
            sb.Remove(0, 2);
            sb.Replace("l", "x");

            Console.WriteLine(sb.ToString()); // print BEFORE clear
            sb.Clear();
           

            Console.WriteLine(sb) ;

            StringBuilder ss = new StringBuilder("hello");

            Console.WriteLine(ss);
        }

    }
}
