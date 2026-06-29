
using Design_Pattern_IMP.Creational;
using Design_Pattern_IMP.Creational.Adopter;
using Design_Pattern_IMP.Creational.Factory;
using System.ComponentModel.DataAnnotations;


//if(true)
//{
//    Logger lg1 = Logger.GetInstance();
//    Logger lg2 = Logger.GetInstance();
//    Logger lg3 = Logger.GetInstance();
//    //true because same instance
//    Console.WriteLine(lg1 == lg2);
//    Console.WriteLine(lg1 == lg2 && lg1 == lg3);

//    lg1.Log("hello message");
//}

// factory like create object one places
//if(true)
//{
//    Ivehicle c1 = VehicleFactory.Create("BMW");

//    Ivehicle c2 = VehicleFactory.Create("Tesla");

//    c1.Drive();
//    c2.Drive();
//}

{
    IPrinter printer = new Printer();
    printer.Print();
}

