using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Learn_Multithreading.M1
{
    internal class ThreadPull_Task
    {

        public Task<int> task = Task.Run(() =>
        {
            return 10;
        });

        public void Work1()
        {
            Console.WriteLine("work 1");
        }

        public void Work2()
        {
            Console.WriteLine("work 2");
        }
        public void Work3()
        {
            Console.WriteLine("work 3");
        }
    }
}
