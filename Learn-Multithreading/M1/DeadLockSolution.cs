using System;
using System.Collections.Generic;
using System.Text;

// use lock in same order

namespace Learn_Multithreading.M1
{
    internal class DeadLockSolution
    {
        object objA = new object();
        object objB = new object();

        public void M1()
        {
            lock (objA)
            {
                Console.WriteLine("M1-Aquire A");
                Thread.Sleep(1000);

                lock (objB)
                {
                    Console.WriteLine("M1-Aquire-B");
                }
            }
        }

        public void M2()
        {
            lock (objA)
            {
                Console.WriteLine("M2-Aquire A");
                Thread.Sleep(1000);

                lock (objB)
                {
                    Console.WriteLine("M2-Aquire B");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}