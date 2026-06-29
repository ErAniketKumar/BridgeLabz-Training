using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Learn_Multithreading.M1
{
    internal class DeadlockExample
    {

        object objA = new object();
        object objB = new object();

        public void M1()
        {
            lock(objA)
            {
                Console.WriteLine("A aquire");
                Thread.Sleep(1000);

                lock(objB)
                {
                    Console.WriteLine("B aquire");
                }
            }
        }

        public void M2()
        {
            lock (objB) {
                Console.WriteLine("aquire B");
                Thread.Sleep(1000);

                lock (objA)
                {
                    Console.WriteLine("aquire A");
                    Thread.Sleep(1000);
                }
            }
    
    }
}
}
