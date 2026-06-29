using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_IMP.Creational
{
    // creating seald class for prevent inheritane with and avoid changing access specifier
    public sealed class Logger
    {
        // static obj because we have to access in static method , static method only access static propery or variable
        private static Logger instance;
        // lock - threading becuase multi threading they check thread one instace == null and same thread two then they create two or more instance 
        private static readonly object _lock = new object();

        // private constructor becuase it prevent object creation outside 
        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            lock(_lock)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }   
        }

        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
