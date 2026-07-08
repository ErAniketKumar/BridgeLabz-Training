using System;
using System.Collections.Generic;
using System.Text;

namespace UNIT_TESTING_R.Linq
{
    internal class Examp1
    {
       public void TravercelCollection()
        {
            List<int> list = new List<int>() { 1, 3, 4, 5, 9, 0, 2 };

            for(int i =0;i<list.Count;i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();

            Dictionary<int, int> dist = new Dictionary<int, int>()
            {
                {1,0 },
                {2,1},
                {2,3 }
            };

            for(var key in dist) { 
            }
        }


    }
}
