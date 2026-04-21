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
            Console.WriteLine(name==name2);
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

            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));

        }

    }
}
