
using Design_Pattern_IMP.Creational;

Logger lg1 = Logger.GetInstance();
Logger lg2 = Logger.GetInstance();
Logger lg3 = Logger.GetInstance();
// true because same instance
//Console.WriteLine(lg1==lg2);
//Console.WriteLine(lg1==lg2 && lg1==lg3);

lg1.Log("hello message");

