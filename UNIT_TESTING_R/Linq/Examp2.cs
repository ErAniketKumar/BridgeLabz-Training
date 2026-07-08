using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UNIT_TESTING_R.Linq
{
    internal class Examp2
    {
       public void Linq1()
        {
            List<int> list = new List<int>() { 1, 2,1,4,5,9, 3, 4, 5, 6, 7 };

            var evenList = list.Where(x => x % 2 == 0).ToList();

            var oddList = list.Where((x) => x % 2 != 0).ToList();


            foreach(var ele in evenList)
            {
                Console.Write(ele + " ");
            }

            Console.WriteLine();
            foreach(var  x in  oddList)
            {
                Console.Write(x+" ");
            }

            Console.WriteLine();

            var slist = list.OrderBy(x => x);

            var dslist = list.OrderByDescending(x => x);

            Console.WriteLine("acending");

            foreach(var ele in slist)
            {
                Console.Write(ele+" ");
            }
            Console.WriteLine();
            Console.WriteLine("decending");
            foreach (var ele in dslist)
            {
                Console.Write(ele + " ");
            }

            List<int> ll10 = new List<int>();
            Console.WriteLine();
            Console.WriteLine("first: "+ll10.First());
            Console.WriteLine("last: " + list.Last());
            Console.WriteLine("first and default: " + ll10.FirstOrDefault());

        }


    }
}
