using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_IMP.Creational
{
    public sealed class Logger
    {
        private static Logger instance;
        private static readonly object _lock = new object();


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
    }
}
