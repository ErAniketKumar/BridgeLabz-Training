using System;
using System.Collections.Generic;
using System.Text;

namespace UNIT_TESTING_R.Linq
{
    internal class Examp1
    {
       public void TravercelCollection()
        {
            List<int> list = new List<int>() { 1, 3, 4, 5, 9, 0, 2,1,2,0,9,5 };

            for(int i =0;i<list.Count;i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();

            Dictionary<int, int> dist = new Dictionary<int, int>()
            {
                {1,0 },
                {2,1},
                {4,3 }
            };

            foreach(var key in dist.Keys) {
                Console.Write(dist[key]);
            }

            Console.WriteLine();
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach(var x in list)
            {
                if(freq.ContainsKey(x))
                {
                    freq[x]++;
                } else
                {
                    freq[x] = 1;
                }
            }

            foreach(var key in freq.Keys)
            {
                Console.WriteLine($"{key}-> {freq[key]}");
            }

            HashSet<int> set = new HashSet<int>();
            for(int i=0;i<list.Count;i++)
            {
                set.Add(list[i]);
            }

            foreach (var x in set) {
                Console.WriteLine(x+" ");
            }

            SortedSet<int> sset = new SortedSet<int>() { 1, 3, 232, 42, 1, 2, 121312, 312312, 31, 1, 2, 23, 23, 21, 0 };

            foreach (var x in sset)
            {
                Console.WriteLine(x+" ");
            }

            sset.Clear();

            for(int i=0;i<list.Count;i++)
            {
                sset.Add(list[i]);
            }

            foreach (var x in sset)
            {
                Console.WriteLine(x + " ");
            }

            SortedDictionary<int, int> sdict = new SortedDictionary<int, int>();

            foreach(var x in list)
            {
                if(sdict.ContainsKey(x))
                {
                    sdict[x]++;
                } else
                {
                    sdict[x] = 1;
                }
            }

            foreach(var keypair in sdict)
            {
                Console.WriteLine(keypair.Key+"->"+ keypair.Value);
            }


            Stack<int> st = new Stack<int>();

            foreach(var x in list)
            {
                st.Push(x);
            }

            while(st.Count>0)
            {
                Console.WriteLine(st.Peek());
                st.Pop();
            }

            Console.WriteLine("queue");

            Queue<int> qu = new Queue<int>();

            foreach(var x in list)
            {
                qu.Enqueue(x);
            }

            foreach(var x in qu)
            {
                Console.WriteLine(x);
            }

            while(qu.Count>0)
            {
                Console.WriteLine(qu.Peek());
                qu.Dequeue();
            }
        }


    }
}
