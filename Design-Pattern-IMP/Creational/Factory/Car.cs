using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_IMP.Creational.Factory
{
    class BMW : Ivehicle
    {
        public void Drive()
        {
            Console.WriteLine("BMW drive");
        }
    }

    class Tesla : Ivehicle
    {
        public void Drive()
        {
            Console.WriteLine("Tesla drive");
        }
    }

    class Toyota : Ivehicle
    {
        public void Drive()
        {
            Console.WriteLine("Toyota drive");
        }
    }
}


