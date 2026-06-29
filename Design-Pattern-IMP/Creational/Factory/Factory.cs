using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_IMP.Creational.Factory
{
    internal class VehicleFactory
    {
        public static Ivehicle Create(string type)
        {
            switch(type)
            {
                case "BMW": 
                    return new BMW();
                case "Toyota":
                    return new Toyota();
                case "Tesla":
                    return new Tesla();
                default:
                    throw new Exception();
            }
        }
    }
}
