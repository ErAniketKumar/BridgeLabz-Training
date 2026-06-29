using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_IMP.Creational.Adopter
{
    class OldPrintter
    {
        public void PrintOld()
        {
            Console.WriteLine("Old printer");
        }
    }

    // i.e in printer have to old functional print so that we create an object of old and called inside print for old printing
    // this is mainly adoper like new one adopt old print
    class Printer : IPrinter
    {
        OldPrintter p = new OldPrintter();
        public void Print()
        {
            p.PrintOld();
        }
    }
}