using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Learn_Multithreading.M1
{
    internal class Example1
    {
        static int count=0;
        public void Increment()
        {
            lock (this)
            {

                for (int i=0;i<10000;i++)
            {
                count++;
            }
            Console.WriteLine(count + " thread name "+Thread.CurrentThread.Name);
            }
    }
}
}
